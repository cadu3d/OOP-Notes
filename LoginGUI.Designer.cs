namespace OOP_Notes
{
    partial class LoginGUI
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
            Login_Label = new Label();
            LoginName_TextBox = new TextBox();
            Login_dateTimePicker = new DateTimePicker();
            LoginSurname_TextBox = new TextBox();
            BirthDate_Label = new Label();
            SuspendLayout();
            // 
            // Login_Label
            // 
            Login_Label.AutoSize = true;
            Login_Label.Font = new Font("Segoe UI", 45F, FontStyle.Bold, GraphicsUnit.Point);
            Login_Label.Location = new Point(151, 18);
            Login_Label.Name = "Login_Label";
            Login_Label.Size = new Size(193, 81);
            Login_Label.TabIndex = 0;
            Login_Label.Text = "Login";
            // 
            // LoginName_TextBox
            // 
            LoginName_TextBox.ForeColor = SystemColors.ButtonShadow;
            LoginName_TextBox.Location = new Point(122, 125);
            LoginName_TextBox.Name = "LoginName_TextBox";
            LoginName_TextBox.Size = new Size(240, 23);
            LoginName_TextBox.TabIndex = 1;
            LoginName_TextBox.Text = "Name";
            // 
            // Login_dateTimePicker
            // 
            Login_dateTimePicker.Format = DateTimePickerFormat.Short;
            Login_dateTimePicker.Location = new Point(122, 183);
            Login_dateTimePicker.Name = "Login_dateTimePicker";
            Login_dateTimePicker.RightToLeft = RightToLeft.No;
            Login_dateTimePicker.Size = new Size(136, 23);
            Login_dateTimePicker.TabIndex = 4;
            Login_dateTimePicker.Value = new DateTime(2023, 6, 28, 16, 37, 26, 0);
            // 
            // LoginSurname_TextBox
            // 
            LoginSurname_TextBox.ForeColor = SystemColors.ButtonShadow;
            LoginSurname_TextBox.Location = new Point(122, 154);
            LoginSurname_TextBox.Name = "LoginSurname_TextBox";
            LoginSurname_TextBox.Size = new Size(240, 23);
            LoginSurname_TextBox.TabIndex = 6;
            LoginSurname_TextBox.Text = "Surname";
            // 
            // BirthDate_Label
            // 
            BirthDate_Label.AutoSize = true;
            BirthDate_Label.Location = new Point(269, 189);
            BirthDate_Label.Name = "BirthDate_Label";
            BirthDate_Label.Size = new Size(93, 15);
            BirthDate_Label.TabIndex = 7;
            BirthDate_Label.Text = "Select Birth Date";
            // 
            // LoginGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(504, 353);
            Controls.Add(BirthDate_Label);
            Controls.Add(LoginSurname_TextBox);
            Controls.Add(Login_dateTimePicker);
            Controls.Add(LoginName_TextBox);
            Controls.Add(Login_Label);
            Name = "LoginGUI";
            Text = "Login Window";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Login_Label;
        private TextBox LoginName_TextBox;
        private DateTimePicker Login_dateTimePicker;
        private TextBox LoginSurname_TextBox;
        private Label BirthDate_Label;
    }
}