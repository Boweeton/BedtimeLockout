namespace ResponsibilityLockoutProgram
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;
    using System.Globalization;
    using System.Text.Json;
    using System.Xml.Serialization;
    using System.IO;

    public partial class LockoutProgram_MainForm : Form
    {
        public bool armed;
        List<Form> childrenForms = new List<Form>();

        private static readonly string settingsFilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "Responsibility Lockout Program",
            "settings.xml");

        public int defaultPushTokenCount = 12;
        public int defaultSnoozeTokenCount = 5;
        public int defaultShutoffTokenCount = 1;
        public TimeOnly defaultLockoutTime = new TimeOnly(22, 15);
        public TimeOnly defaultUnlockTime = new TimeOnly(5, 00);

        public UserSettings CurrentSettings { get; set; }

        private Timer countdownTimer;
        public TimeOnly TargetLockingTime { set; get; } // The time we're counting down to
        string timerMessage;
        TimeOnly borrowedTimeTarget;
        TimeSpan remainingTime;
        public bool isLocked;
        public bool isBorrowingTime;

        public LockoutProgram_MainForm()
        {
            InitializeComponent();

            // Load in Settings / Set Default Values
            LoadSettings();

            // Set the form's start position to center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Initialize and configure the timer
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000; // 1 second intervals
            countdownTimer.Tick += CountdownTimer_Tick; // Event to handle countdown update
            countdownTimer.Start(); // Start the countdown

            // Set up initial state
            TargetLockingTime = new TimeOnly(CurrentSettings.LockoutTime.Hour, CurrentSettings.LockoutTime.Minute, 0);
            armed = false;
            if (CurrentMoment() > CurrentSettings.LockoutTime && CurrentMoment() <= CurrentSettings.UnlockTime)
            {
                isLocked = false;
            }
            else
            {
                isLocked = true;
            }
        }


        // == 🔽 HELPER METHODS 🔽 ==================================================

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            // Calculate the remaining time
            remainingTime = TargetLockingTime - CurrentMoment();

            if (remainingTime.TotalSeconds > 1)
            {
                label_TestDisplay.Text = $"Sec Remain:\r\n{remainingTime.TotalSeconds:00.00}";

                int displayHour = (TargetLockingTime.Hour) >= 13 ? (TargetLockingTime.Hour) - 12 : (TargetLockingTime.Hour); // Converts 24h time to 12h time
                string displayHourSuffex = TargetLockingTime.Hour > 12 ? "PM" : "AM"; // Sets AM or PM based on if target time was converted or not

                // State 1: Unlocked - counting down to lock time
                if (!isLocked && !isBorrowingTime)
                {
                    timerMessage = $"Time Until\r\nLockout at\r\n{displayHour}:{TargetLockingTime.Minute:00} {displayHourSuffex}";
                }

                // State 2: Locked - counting down to unlock time (covered, lol)
                if (isLocked && !isBorrowingTime)
                {
                    timerMessage = $"Time Until\r\nUnlockout at\r\n{displayHour}:{TargetLockingTime.Minute:00} {displayHourSuffex}";
                }

                // State 3: Borrowing Time - counting down to how much time was just borrowed
                if (isBorrowingTime)
                {
                    timerMessage = $"Borrowing Time!\r\nRemaining Time:";
                }


                // Set the display message for the timer & Update the label with the formatted time (hh:mm:ss)
                label_CountdownTitle.Text = timerMessage;
                label_Countdown.Text = remainingTime.ToString(@"hh\:mm\:ss");
            }
            else
            {
                SwitchToNight();
            }


            if (remainingTime.TotalSeconds > 0)
            {
                // Update the label with the formatted time (hh:mm:ss)
                label_Countdown.Text = remainingTime.ToString(@"hh\:mm\:ss");

                int displayHour = (TargetLockingTime.Hour) >= 13 ? (TargetLockingTime.Hour) - 12 : (TargetLockingTime.Hour); // Converts 24h time to 12h time
                string displayHourSuffex = TargetLockingTime.Hour > 12 ? "PM" : "AM"; // Sets AM or PM based on if target time was converted or not
                label_CountdownTitle.Text = $"Time Until\r\nLockout at\r\n{displayHour}:{TargetLockingTime.Minute:00} {displayHourSuffex}";
            }
            else // TargetTime has been reached
            {
                if (ShouldLock()) // it is night time
                {
                    SwitchToNight();
                }
                else // It is day time
                {
                    SwitchToDay();
                }
            }
        }

        public void SwitchToBorrowedTime(int minutesToBorrow)
        {
            TargetLockingTime = CurrentMoment();
            TargetLockingTime = TargetLockingTime.AddMinutes(minutesToBorrow);
            isBorrowingTime = true;
            isLocked = false;
        }

        public void SwitchToLockout()
        {
            TargetLockingTime = CurrentSettings.LockoutTime;
            isBorrowingTime = false;
            isLocked = false;
        }

        public void SwitchToUnlock()
        {
            TargetLockingTime = CurrentSettings.UnlockTime;
            isBorrowingTime = false;
            isLocked = true;
        }

        public bool CheckForLockout()
        {
            TimeOnly currentTime = CurrentMoment();         // Get current time
            TimeOnly lockoutTime = CurrentSettings.LockoutTime; // Lockout start time
            TimeOnly unlockTime = CurrentSettings.UnlockTime;   // Unlock time

            // Case 1: Lockout time is after unlock time (lockout crosses over midnight)
            if (lockoutTime > unlockTime)
            {
                // If the current time is after lockout or before unlock, it's in the lockout period
                if (currentTime >= lockoutTime || currentTime < unlockTime)
                {
                    return true; // It's lockout time
                }
            }
            // Case 2: Lockout and unlock on the same day (no midnight crossover)
            else if (lockoutTime < unlockTime)
            {
                // If the current time is between lockout and unlock, it's in the lockout period
                if (currentTime >= lockoutTime && currentTime < unlockTime)
                {
                    return true; // It's lockout time
                }
            }

            // If none of the conditions match, it's not in the lockout period
            return false;
        } // Done

        public bool CheckForUnlock()
        {
            TimeOnly currentTime = CurrentMoment();         // Get current time
            TimeOnly lockoutTime = CurrentSettings.LockoutTime; // Lockout start time
            TimeOnly unlockTime = CurrentSettings.UnlockTime;   // Unlock time

            // Case 1: Lockout time is after unlock time (lockout crosses over midnight)
            if (lockoutTime > unlockTime)
            {
                // If the current time is after unlock and before lockout, it's in the unlocked period
                if (currentTime >= unlockTime && currentTime < lockoutTime)
                {
                    return true; // It's unlock time
                }
            }
            // Case 2: Lockout and unlock on the same day (no midnight crossover)
            else if (lockoutTime < unlockTime)
            {
                // If the current time is not between lockout and unlock, it's unlocked
                if (currentTime < lockoutTime || currentTime >= unlockTime)
                {
                    return true; // It's unlock time
                }
            }

            // If none of the conditions match, it's still lockout time
            return false;
        } // Done



        public bool CanLoadInSettings()
        {
            // Check if the settings file exists at the specified location
            return File.Exists(settingsFilePath);
        }

        public void LoadSettings()
        {
            if (CanLoadInSettings())
            {
                // If the settings file exists, deserialize the XML file into UserSettings
                XmlSerializer serializer = new XmlSerializer(typeof(UserSettings));
                using (FileStream fs = new FileStream(settingsFilePath, FileMode.Open))
                {
                    UserSettings loadedSettings = (UserSettings)serializer.Deserialize(fs);
                    // Assuming you have a field or property to hold the current settings
                    CurrentSettings = loadedSettings;
                }
            }
            else
            {
                // Handle cases where no settings file exists (maybe load defaults)
                ResetToDefaultSettings();
            }
        }

        public void SaveSettings(UserSettings savableSettings)
        {
            // Create the directory if it does not exist
            string directory = Path.GetDirectoryName(settingsFilePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // Serialize the settings into the XML file
            XmlSerializer serializer = new XmlSerializer(typeof(UserSettings));
            using (FileStream fs = new FileStream(settingsFilePath, FileMode.Create))
            {
                serializer.Serialize(fs, savableSettings);
            }
        }

        public void ResetToDefaultSettings()
        {
            CurrentSettings = new UserSettings(defaultPushTokenCount, defaultSnoozeTokenCount, defaultShutoffTokenCount, defaultLockoutTime, defaultUnlockTime);
            SaveSettings(CurrentSettings);
        }


        public void CloseAllChildren()
        {
            if (childrenForms.Count > 0)
            {
                foreach (Form f in childrenForms)
                {
                    f.Close();
                }
                childrenForms = new List<Form>();
            }
            else
            {
                childrenForms = new List<Form>();
            }
        }

        public void Lockout()
        {
            // Get all screens (monitors)
            Screen[] screens = Screen.AllScreens;

            // Create a form for each screen and display it
            for (int i = 0; i < screens.Length; i++)
            {
                // Create a new instance of the LockoutScreenForm
                LockoutScreenForm lockoutForm = new LockoutScreenForm(this);

                // Position the form on the specific screen
                lockoutForm.StartPosition = FormStartPosition.Manual;
                lockoutForm.Location = screens[i].Bounds.Location;  // Set form location to match screen

                // Show the form without blocking the current thread (non-modal)
                lockoutForm.Show();

                // Add the form to the existing childrenForms list
                childrenForms.Add(lockoutForm);
            }
        }

        public void Unlock()
        {
            CloseAllChildren();
        }

        public void SwitchToNight()
        {
            //isLocked = true;
            Lockout();
            TargetLockingTime = CurrentSettings.UnlockTime;
        }

        public void SwitchToDay()
        {
            isLocked = false;
            Unlock();
            TargetLockingTime = CurrentSettings.LockoutTime;
        }

        public TimeOnly CurrentMoment()
        {
            return TimeOnly.FromDateTime(DateTime.Now);
        }

        public bool ShouldLock()
        {
            TimeOnly currentTime = CurrentMoment(); // Assuming CurrentMoment() returns TimeOnly
            TimeOnly lockoutTime = TargetLockingTime;
            TimeOnly unlockTime = CurrentSettings.UnlockTime;

            // Case 1: Lockout and unlock are on the same day (lockout time is before unlock time)
            if (lockoutTime < unlockTime)
            {
                // If the current time is between lockout and unlock, lock the system
                if (currentTime >= lockoutTime && currentTime < unlockTime)
                {
                    return true;
                }
            }
            // Case 2: Lockout crosses over midnight (lockout time is after unlock time)
            else if (lockoutTime > unlockTime)
            {
                // If the current time is after lockout time and before midnight, lock the system
                if (currentTime >= lockoutTime || currentTime < unlockTime)
                {
                    return true;
                }
            }

            // If none of the conditions match, no lock should occur
            return false;
        }

        public void BuyTime(int minutes)
        {
            TargetLockingTime = CurrentMoment();
            TargetLockingTime = TargetLockingTime.AddMinutes(minutes);
        }

        private void CenterControlHorizontally(Control controlToCenter, Control parentControl)
        {
            // Ensure the control has a parent (to center in)
            if (parentControl != null)
            {
                // Calculate the new X position to center the control
                int parentWidth = parentControl.ClientSize.Width;
                int controlWidth = controlToCenter.Width;

                // Set the control's Left property to horizontally center it within the parent control
                controlToCenter.Left = (parentWidth - controlWidth) / 2;
            }
        }

        private bool IsValidTime(string inputTime)
        {
            if (string.IsNullOrWhiteSpace(inputTime))
                return false;

            // Normalize spaces and case
            inputTime = inputTime.Trim().ToUpper();

            // Define regex for both 12-hour (with AM/PM) and 24-hour formats
            string pattern = @"^([01]?\d|2[0-3])\s*:\s*[0-5]\d\s*(AM|PM)?$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

            return regex.IsMatch(inputTime);
        }

        public TimeOnly GetTimeFromString(string stringTime)
        {
            if (!IsValidTime(stringTime))
                return new TimeOnly(0);

            // Normalize spaces and case
            stringTime = stringTime.Trim().ToUpper();

            // Replace multiple spaces with a single space
            stringTime = Regex.Replace(stringTime, @"\s+", "");

            // Add a space before "AM" or "PM" if it's missing
            if (stringTime.EndsWith("AM") || stringTime.EndsWith("PM"))
            {
                stringTime = Regex.Replace(stringTime, @"(AM|PM)", " $1"); // Ensures space before "AM" or "PM"
            }

            // Try parsing the time with different formats (12-hour and 24-hour)
            TimeOnly parsedTime;

            // Handle 12-hour format with AM/PM
            if (stringTime.Contains("AM") || stringTime.Contains("PM"))
            {
                parsedTime = TimeOnly.ParseExact(stringTime, "h:mm tt", CultureInfo.InvariantCulture);
            }
            // Handle 24-hour format (without AM/PM)
            else
            {
                parsedTime = TimeOnly.ParseExact(stringTime, "H:mm", CultureInfo.InvariantCulture);
            }

            return parsedTime;
        }

        public string ConvertTimeTo12HourDisplay(TimeOnly inputTime)
        {
            if (inputTime.Hour >= 13)
            {
                return $"{inputTime.Hour - 12}:{inputTime.Minute:00} PM";
            }
            else
            {
                return $"{inputTime.Hour}:{inputTime.Minute:00} AM";
            }
        }

        private void RecenterWindowObjects()
        {
            CenterControlHorizontally(panel_Time, this);
            CenterControlHorizontally(button_Settings, this);
            CenterControlHorizontally(button_ArmedStatus, this);
            CenterControlHorizontally(button_ResetUserSettings, this);
            CenterControlHorizontally(testButton, this);
            CenterControlHorizontally(label_CountdownTitle, panel_Time);
            CenterControlHorizontally(label_Countdown, panel_Time);
            CenterControlHorizontally(label_CountdownLegend, panel_Time);
            CenterControlHorizontally(panel_EasySettings, this);
            CenterControlHorizontally(label_EasySettingsTitle, panel_EasySettings);
            CenterControlHorizontally(button_SetEasySettings, panel_EasySettings);
            CenterControlHorizontally(textBox_EasySettingsInput, panel_EasySettings);
            CenterControlHorizontally(label_EasySettingsStatus, panel_EasySettings);
            CenterControlHorizontally(label_TestDisplay, this);
        }




        // == 🔽 FORM EVENTS 🔽 ==================================================

        private void Form1_Load(object sender, EventArgs e)
        {
            RecenterWindowObjects();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            Lockout();
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this);
            settingsForm.ShowDialog();
        }

        private void button_ArmedStatus_Click(object sender, EventArgs e)
        {
            if (armed)
            {
                UserMessageForm userMessageForm = new UserMessageForm(
                ParentForm: this,
                DisplayMessage: "Are you sure!?\r\nYou need to be responsible!\r\n\r\nThink of your family!",
                UsesBothButtons: true,
                OptionOneText: "Turn Off ✖️",
                OptionTwoText: "Leave On ✔️",
                PassPhrase: "LMAO CLOSE",
                BackgroundColor: Color.Coral
                );
                DialogResult result = userMessageForm.ShowDialog();

                if (result == DialogResult.Yes)
                {
                    button_ArmedStatus.Text = "disarmed";
                    armed = false;
                    button_ArmedStatus.BackColor = this.BackColor;
                }
            }
            else
            {
                button_ArmedStatus.Text = "ARMED";
                armed = true;
                button_ArmedStatus.BackColor = Color.IndianRed;
            }
        }

        private void LockoutProgram_MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Prevent the form from closing if armed
            if (armed)
            {
                e.Cancel = true;

                UserMessageForm userMessageForm = new UserMessageForm(
                ParentForm: this,
                DisplayMessage: "Cannot close while armed!\r\nDisarm to close.",
                UsesBothButtons: false,
                OptionOneText: "Okay",
                OptionTwoText: string.Empty,
                BackgroundColor: Color.Coral
                );
                userMessageForm.ShowDialog();
            }
        }

        private void button_SetEasySettings_Click(object sender, EventArgs e)
        {
            if (IsValidTime(textBox_EasySettingsInput.Text))
            {
                TimeOnly time = GetTimeFromString(textBox_EasySettingsInput.Text);
                label_EasySettingsStatus.Text = $"Time format: GOOD\r\n{ConvertTimeTo12HourDisplay(time)}";
                CenterControlHorizontally(label_EasySettingsStatus, panel_EasySettings);

                TimeOnly userInputTime = new TimeOnly(time.Hour, time.Minute, 0);

                CurrentSettings.LockoutTime = userInputTime;
                TargetLockingTime = userInputTime;

                SaveSettings(CurrentSettings);

                // Swap to night if new time is before now
                if (ShouldLock())
                {
                    SwitchToNight();
                }
            }
            else
            {
                label_EasySettingsStatus.Text = "Time format: BAD";
                CenterControlHorizontally(label_EasySettingsStatus, panel_EasySettings);
            }
        }

        private void textBox_EasySettingsInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Do something when Enter is pressed
                button_SetEasySettings_Click(sender, e);

                // Optionally, prevent the 'ding' sound that happens when pressing Enter
                e.SuppressKeyPress = true;
            }
        }

        private void button_ResetUserSettings_Click(object sender, EventArgs e)
        {
            ResetToDefaultSettings();
            TargetLockingTime = CurrentSettings.LockoutTime;
        }

        private void LockoutProgram_MainForm_Resize(object sender, EventArgs e)
        {
            RecenterWindowObjects();
        }
    }
}
