namespace OOP_Notes
{
    partial class StartGUI
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
            BankSim_Label = new Label();
            CreateATM_Button = new Button();
            CreateBank_Button = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            listBox2 = new ListBox();
            Bank_listBox = new ListBox();
            Information_label = new Label();
            itemInformation_label = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // BankSim_Label
            // 
            BankSim_Label.AutoSize = true;
            BankSim_Label.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            BankSim_Label.Location = new Point(166, 9);
            BankSim_Label.Name = "BankSim_Label";
            BankSim_Label.Size = new Size(174, 47);
            BankSim_Label.TabIndex = 0;
            BankSim_Label.Text = "Bank Sim";
            // 
            // CreateATM_Button
            // 
            CreateATM_Button.Anchor = AnchorStyles.None;
            CreateATM_Button.Location = new Point(246, 8);
            CreateATM_Button.Name = "CreateATM_Button";
            CreateATM_Button.Size = new Size(174, 34);
            CreateATM_Button.TabIndex = 2;
            CreateATM_Button.Text = "Create ATM";
            CreateATM_Button.UseVisualStyleBackColor = true;
            // 
            // CreateBank_Button
            // 
            CreateBank_Button.Anchor = AnchorStyles.None;
            CreateBank_Button.Location = new Point(24, 8);
            CreateBank_Button.Name = "CreateBank_Button";
            CreateBank_Button.Size = new Size(174, 34);
            CreateBank_Button.TabIndex = 1;
            CreateBank_Button.Text = "Create Bank";
            CreateBank_Button.UseVisualStyleBackColor = true;
            CreateBank_Button.MouseClick += CreateBank_Button_MouseClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(listBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(CreateBank_Button, 0, 0);
            tableLayoutPanel1.Controls.Add(CreateATM_Button, 1, 0);
            tableLayoutPanel1.Controls.Add(Bank_listBox, 0, 1);
            tableLayoutPanel1.Location = new Point(36, 59);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.7731953F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 74.22681F));
            tableLayoutPanel1.Size = new Size(445, 194);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(225, 53);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(217, 124);
            listBox2.TabIndex = 4;
            // 
            // Bank_listBox
            // 
            Bank_listBox.FormattingEnabled = true;
            Bank_listBox.ItemHeight = 15;
            Bank_listBox.Location = new Point(3, 53);
            Bank_listBox.Name = "Bank_listBox";
            Bank_listBox.Size = new Size(216, 124);
            Bank_listBox.TabIndex = 3;
            Bank_listBox.SelectedIndexChanged += Bank_listBox_SelectedIndexChanged;
            // 
            // Information_label
            // 
            Information_label.AutoSize = true;
            Information_label.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            Information_label.Location = new Point(166, 271);
            Information_label.Name = "Information_label";
            Information_label.Size = new Size(217, 47);
            Information_label.TabIndex = 4;
            Information_label.Text = "Information";
            // 
            // itemInformation_label
            // 
            itemInformation_label.AutoSize = true;
            itemInformation_label.Location = new Point(88, 349);
            itemInformation_label.Name = "itemInformation_label";
            itemInformation_label.Size = new Size(0, 15);
            itemInformation_label.TabIndex = 5;
            // 
            // StartGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 513);
            Controls.Add(itemInformation_label);
            Controls.Add(Information_label);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(BankSim_Label);
            Name = "StartGUI";
            Text = "Bank Sim Window";
            Load += StartGUI_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BankSim_Label;
        private Button CreateATM_Button;
        private Button CreateBank_Button;
        private TableLayoutPanel tableLayoutPanel1;
        private ListBox Bank_listBox;
        private ListBox listBox2;
        private Label Information_label;
        private Label itemInformation_label;
    }
}