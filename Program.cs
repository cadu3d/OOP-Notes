namespace OOP_Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            Program test = new Program();
            test.CreateBankMain();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartGUI());


           // Bank.bankCreated += test.Print;


        }

        public void CreateBankMain()
        {
            Bank banco1 = new("Novo1", "rua tal", 10000);
            Bank banco2 = new("Novo2", "rua tal2", 10002);
            Bank banco3 = new("Novo3", "rua tal2", 10002);
            Bank banco4 = new("Novo4", "rua tal2", 10002);
            Bank banco5 = new("Novo5", "rua tal2", 10002);
        }

        public void Print(Bank T)
        {
            foreach (Bank banco in Bank.BankList) { Console.WriteLine(banco.BankName); }
        }

    }

}