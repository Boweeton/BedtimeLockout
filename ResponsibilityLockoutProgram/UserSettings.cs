using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ResponsibilityLockoutProgram
{
    public class UserSettings
    {
        public int PushTokenCount;
        public int SnoozeTokenCount;
        public int ShutoffTokenCount;

        // Use string as intermediary for TimeOnly serialization
        public string LockoutTimeString
        {
            get => LockoutTime.ToString("HH:mm");
            set => LockoutTime = TimeOnly.Parse(value);
        }

        public string UnlockTimeString
        {
            get => UnlockTime.ToString("HH:mm");
            set => UnlockTime = TimeOnly.Parse(value);
        }

        [XmlIgnore]
        public TimeOnly LockoutTime { get; set; }

        [XmlIgnore]
        public TimeOnly UnlockTime { get; set; }

        // Constructor
        public UserSettings(int pushTokenCount, int snoozeTokenCount, int shutoffTokenCount, TimeOnly lockoutTime, TimeOnly unlockTime)
        {
            PushTokenCount = pushTokenCount;
            SnoozeTokenCount = snoozeTokenCount;
            ShutoffTokenCount = shutoffTokenCount;
            LockoutTime = lockoutTime;
            UnlockTime = unlockTime;
        }

        public UserSettings() { } // Parameterless constructor for deserialization
    }

}
