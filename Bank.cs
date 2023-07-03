using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Notes
{

    internal class Bank
    {   
        //Global varialbles
        public static List<Bank> BankList = new List<Bank>();

        //Instance fields
        public string BankName { get; set; }
        public string Aderss { get; set; }
        public float MoneyReserve { get; set; }
        public List<Account> BankAccounts { get; set; }

        //Events
        public delegate void BankCreate(Bank sender);
        public static BankCreate bankCreated;

        //Constructor
        public Bank(string Name, string Adress, float Reserve)
        {
            this.BankName = Name;
            this.Aderss = Adress;
            this.MoneyReserve = Reserve;
            this.BankAccounts = new List<Account>();

            //after a bank is created, add it to the global list and trigger event
            BankList.Add(this);
            bankCreated?.Invoke(this);
        }

        public Account GetAndValidate(string name, string pass)
        {
            //IEnumerabl could be replaced with "var queary"
            IEnumerable<Account> query = from acount in BankAccounts
                                         where acount.Manager.Name == name && acount.Password == pass
                                         select acount;
            if (query.Count() > 0)
            {
                return query.FirstOrDefault(); ;
            }
            else
            {
                // Return an error message indicating invalid username or password
                throw new Exception("Invalid username or password.");
            }

        }

        public void AddMoney(float value, string name)
        {


            // Acount[i]._totalMoney += Math.Max(0, value);//tratamento para valores negativos, escolhe o maior numero entre valor e zer
        }

        public void RemoveMoney(float value)
        {
            // this._totalMoney -= Math.Max(0, value);
        }
    }
    class Account
    {
        public Client Manager;
        public string Password;
        private float _totalMoney = 0;
        private Client[] _afiliates;
        public Account() { }
    }

}





