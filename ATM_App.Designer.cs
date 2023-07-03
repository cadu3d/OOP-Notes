namespace OOP_Notes
{
    partial class ATM_App
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
            ATMLabel = new Label();
            LoginButton = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // ATMLabel
            // 
            ATMLabel.AutoSize = true;
            ATMLabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            ATMLabel.Location = new Point(136, 31);
            ATMLabel.Name = "ATMLabel";
            ATMLabel.Size = new Size(102, 50);
            ATMLabel.TabIndex = 0;
            ATMLabel.Text = "ATM";
            ATMLabel.Click += label1_Click;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(103, 106);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(166, 23);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(103, 135);
            button2.Name = "button2";
            button2.Size = new Size(166, 23);
            button2.TabIndex = 2;
            button2.Text = "Create Account";
            button2.UseVisualStyleBackColor = true;
            // 
            // ATM_App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 461);
            Controls.Add(button2);
            Controls.Add(LoginButton);
            Controls.Add(ATMLabel);
            Name = "ATM_App";
            Text = "ATM";
            Load += ATM_App_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ATMLabel;
        private Button LoginButton;
        private Button button2;
    }
}