using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Notes
{
    public class Citzen
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        private DateTime _birthDate;
        private int _age;
        private void calcAge()

        {
            this._age = DateTime.Today.Year - _birthDate.Year;
        }

        public Citzen() { }
    }

    public class Client : Citzen
    {
        public string Password { get; set; } = string.Empty;
        public DateTime DateEntered { get; } = DateTime.Now;

        public Client() { }
    }

}

