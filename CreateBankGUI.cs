using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP_Notes
{
    public partial class CreateBankGUI : Form
    {
        public float Money_Reserve = 0;

        public CreateBankGUI()
        {
            InitializeComponent();
        }

        private void BankCreatorName_textBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (BankCreatorName_textBox.Text == "Name")
                BankCreatorName_textBox.Text = "";
            BankCreatorName_textBox.ForeColor = Color.Black;

        }
        private void BankCreator_richTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (BankCreator_richTextBox.Text == "Address")
                BankCreator_richTextBox.Text = "";
            BankCreator_richTextBox.ForeColor = Color.Black;

        }
        private void BankCreator_richTextBox_Enter(object sender, EventArgs e)
        {
            if (BankCreator_richTextBox.Text == "Address")
                BankCreator_richTextBox.Text = "";
            BankCreator_richTextBox.ForeColor = Color.Black;

        }
        private void Reserve_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Reserve_textBox.Text == "Money Reserve")
                Reserve_textBox.Text = "";
            Reserve_textBox.ForeColor = Color.Black;
        }

        private void BankCreator_button_MouseClick(object sender, MouseEventArgs e)
        {
            string name = BankCreatorName_textBox.Text;
            string address = BankCreator_richTextBox.Text;
            //string reserve = Reserve_textBox.Text;
            Bank banco = new(name, address, Money_Reserve);

            MessageBox.Show("Bank Name: " + banco.BankName + "\n" + "Bank Adress: " + banco.Aderss + "\n" + "Bnak Rerserve: "+ Convert.ToString(Money_Reserve));
            //Console.WriteLine(banco.BankName + "\n" + banco.Aderss + "\n" + Convert.ToString(Money_Reserve));
        }

        private void Reserve_textBox_TextChanged(object sender, EventArgs e)
        {
            if (!float.TryParse(Reserve_textBox.Text, out float result))
            {
                Reserve_textBox.Text = ""; // Clear the invalid input if parsing is not possible

            }
            Money_Reserve = result;
        }
    }
}
