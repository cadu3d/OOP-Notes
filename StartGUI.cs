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
            //Console.WriteLine("chamou");
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
            foreach (Bank bank in Bank.BankList) { Bank_listBox.Items.Add(bank.BankName); }

        }
    }
}
