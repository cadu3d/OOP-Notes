using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Notes
{
    public partial class StartGUI : Form
    {

        private LoginGUI Login = new();

        public StartGUI()
        {
            InitializeComponent();

            //first subtcription via static delegate triggered by Bank creation
            Bank.bankCreated += CreateBank_ListBox_AddBank;
        }

        private void CreateBank_ListBox_AddBank(Bank sender)
        {
            Console.WriteLine("chamou");
            //Bank_listBox.Items.Add(sender.BankName);

            Bank_listBox.Items.Clear();
            foreach (Bank bank in Bank.BankList) { Bank_listBox.Items.Add(bank.BankName); }

            //secondary subscriptions triggered the object events  

        }

        private void CreateBank_Button_MouseClick(object sender, MouseEventArgs e)
        {
            CreateBankGUI createBank = new CreateBankGUI();
            createBank.Show();

        }

        private void StartGUI_Load(object sender, EventArgs e)
        {
            Information_label.Hide();
            itemInformation_label.Hide();
            foreach (Bank bank in Bank.BankList) { Bank_listBox.Items.Add(bank.BankName); }

        }

        private void Bank_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int newHeight = 800;
            this.Height = newHeight;
            itemInformation_label.Show();
            Information_label.Show();

            var queary = from bank in Bank.BankList
                         where bank.BankName == Bank_listBox.Text
                         select bank;

            itemInformation_label.Text = "Bank Name: " + queary.FirstOrDefault().BankName + "\n" + "Bank Adress: " + queary.FirstOrDefault().Aderss + "\n" + "Bnak Rerserve: " + Convert.ToString(queary.FirstOrDefault().MoneyReserve);

            //if (Bank_listBox.SelectedItem != null)
            //{
            //foreach (var item in Bank.BankList)
            //{
            //if (item.BankName == Bank_listBox.SelectedItem.ToString())
            //{
            //itemInformation_label.Text = "Bank Name: " + item.BankName + "\n" + "Bank Adress: " + item.Aderss + "\n" + "Bnak Rerserve: " + Convert.ToString(item.MoneyReserve);
            //}
            //}
            //}



        }
    }
}
