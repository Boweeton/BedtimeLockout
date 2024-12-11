namespace ResponsibilityLockoutProgram
{
    partial class UserMessageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_UserMessage = new Label();
            button_Option1 = new Button();
            button_Option2 = new Button();
            textBox_passPhraseInput = new TextBox();
            SuspendLayout();
            // 
            // label_UserMessage
            // 
            label_UserMessage.AutoSize = true;
            label_UserMessage.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_UserMessage.Location = new Point(12, 9);
            label_UserMessage.Name = "label_UserMessage";
            label_UserMessage.Size = new Size(430, 64);
            label_UserMessage.TabIndex = 2;
            label_UserMessage.Text = "Hello World. Good morning.\r\nThis is a test of the messaging system.";
            label_UserMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Option1
            // 
            button_Option1.Cursor = Cursors.Hand;
            button_Option1.Font = new Font("Segoe UI", 15.75F);
            button_Option1.Location = new Point(153, 168);
            button_Option1.Name = "button_Option1";
            button_Option1.Size = new Size(131, 45);
            button_Option1.TabIndex = 1;
            button_Option1.Text = "Option 1";
            button_Option1.UseVisualStyleBackColor = true;
            button_Option1.Click += button_Option1_Click;
            button_Option1.MouseMove += button_Option1_MouseMove;
            // 
            // button_Option2
            // 
            button_Option2.Cursor = Cursors.Hand;
            button_Option2.Font = new Font("Segoe UI", 15.75F);
            button_Option2.Location = new Point(153, 236);
            button_Option2.Name = "button_Option2";
            button_Option2.Size = new Size(131, 45);
            button_Option2.TabIndex = 0;
            button_Option2.Text = "Option 2";
            button_Option2.UseVisualStyleBackColor = true;
            button_Option2.Click += button_Option2_Click;
            // 
            // textBox_passPhraseInput
            // 
            textBox_passPhraseInput.CharacterCasing = CharacterCasing.Upper;
            textBox_passPhraseInput.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_passPhraseInput.Location = new Point(12, 91);
            textBox_passPhraseInput.Name = "textBox_passPhraseInput";
            textBox_passPhraseInput.Size = new Size(359, 32);
            textBox_passPhraseInput.TabIndex = 3;
            textBox_passPhraseInput.Text = "ALL YOUR BASE ARE BELONG TO US! YEET YEET";
            textBox_passPhraseInput.TextChanged += textBox_passPhraseInput_TextChanged;
            // 
            // UserMessageForm
            // 
            AcceptButton = button_Option1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button_Option2;
            ClientSize = new Size(508, 312);
            Controls.Add(textBox_passPhraseInput);
            Controls.Add(button_Option2);
            Controls.Add(button_Option1);
            Controls.Add(label_UserMessage);
            Name = "UserMessageForm";
            StartPosition = FormStartPosition.Manual;
            Text = "UserMessageForm";
            FormClosed += UserMessageForm_FormClosed;
            Load += UserMessageForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_UserMessage;
        private Button button_Option1;
        private Button button_Option2;
        private TextBox textBox_passPhraseInput;
    }
}