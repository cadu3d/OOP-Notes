namespace OOP_Notes
{
    partial class CreateBankGUI
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
            BankCreator_label = new Label();
            BankCreatorName_textBox = new TextBox();
            BankCreator_richTextBox = new RichTextBox();
            Reserve_textBox = new TextBox();
            BankCreator_button = new Button();
            SuspendLayout();
            // 
            // BankCreator_label
            // 
            BankCreator_label.AutoSize = true;
            BankCreator_label.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            BankCreator_label.Location = new Point(48, 31);
            BankCreator_label.Name = "BankCreator_label";
            BankCreator_label.Size = new Size(235, 47);
            BankCreator_label.TabIndex = 0;
            BankCreator_label.Text = "Bank Creator";
            BankCreator_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BankCreatorName_textBox
            // 
            BankCreatorName_textBox.ForeColor = SystemColors.ScrollBar;
            BankCreatorName_textBox.Location = new Point(59, 99);
            BankCreatorName_textBox.Name = "BankCreatorName_textBox";
            BankCreatorName_textBox.Size = new Size(207, 23);
            BankCreatorName_textBox.TabIndex = 1;
            BankCreatorName_textBox.Text = "Name";
            BankCreatorName_textBox.MouseClick += BankCreatorName_textBox_MouseClick;
            // 
            // BankCreator_richTextBox
            // 
            BankCreator_richTextBox.ForeColor = SystemColors.ScrollBar;
            BankCreator_richTextBox.Location = new Point(59, 143);
            BankCreator_richTextBox.Name = "BankCreator_richTextBox";
            BankCreator_richTextBox.Size = new Size(207, 96);
            BankCreator_richTextBox.TabIndex = 2;
            BankCreator_richTextBox.Text = "Address";
            BankCreator_richTextBox.MouseClick += BankCreator_richTextBox_MouseClick;
            BankCreator_richTextBox.Enter += BankCreator_richTextBox_Enter;
            // 
            // Reserve_textBox
            // 
            Reserve_textBox.ForeColor = SystemColors.ScrollBar;
            Reserve_textBox.Location = new Point(59, 258);
            Reserve_textBox.Name = "Reserve_textBox";
            Reserve_textBox.Size = new Size(207, 23);
            Reserve_textBox.TabIndex = 3;
            Reserve_textBox.Text = "Money Reserve";
            Reserve_textBox.MouseClick += Reserve_TextBox_MouseClick;
            Reserve_textBox.TextChanged += Reserve_textBox_TextChanged;
            // 
            // BankCreator_button
            // 
            BankCreator_button.Location = new Point(116, 297);
            BankCreator_button.Name = "BankCreator_button";
            BankCreator_button.Size = new Size(97, 23);
            BankCreator_button.TabIndex = 4;
            BankCreator_button.Text = "Create";
            BankCreator_button.UseVisualStyleBackColor = true;
            BankCreator_button.MouseClick += BankCreator_button_MouseClick;
            // 
            // CreateBankGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 449);
            Controls.Add(BankCreator_button);
            Controls.Add(Reserve_textBox);
            Controls.Add(BankCreator_richTextBox);
            Controls.Add(BankCreatorName_textBox);
            Controls.Add(BankCreator_label);
            Name = "CreateBankGUI";
            Text = "Bank Creator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BankCreator_label;
        private TextBox BankCreatorName_textBox;
        private RichTextBox BankCreator_richTextBox;
        private TextBox Reserve_textBox;
        private Button BankCreator_button;
    }
}