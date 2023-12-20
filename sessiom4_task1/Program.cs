namespace sessiom4_task1
{
    enum menuoptions
    {
        withdraw = 0, deposite = 1, print = 2, quit = 3
    }
    internal class Program
    {
       
        public static menuoptions readoptions()
         


        {
          
              //menuoptions options = (menuoptions)Convert.ToInt32(Console.ReadLine());
            //string input;
            do
            {
                Console.WriteLine("Menu Options:");
                Console.WriteLine("0. Withdraw");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Print");
                Console.WriteLine("3. Quit");
                //if (options == 0)
                //    return menuoptions.withdraw;
                Console.Write("Enter your choice (0-3): ");
                   string input = Console.ReadLine();

                if (Enum.TryParse(input, out menuoptions userOption) )
                {
                    return userOption;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please enter a valid menu option.");
                }

                //  if(Enum.TryParse())

            } while (true);
        }
        private static void DoDeposit(Account account)
        {
            Console.Write("Enter deposit amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            account.deposite(amount);
            account.print();


            //if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
            //{
            //    account.deposite(depositAmount);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input for deposit amount.");
            //}
        }
        private static void Dowithdraw(Account account)
        {
            Console.Write("Enter withdraw amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            account.withdraw(amount);
            account.print();

        }
        private static void DoPrint(Account account)
        {
            account.print();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Account newaccount = new Account("ahmed",20000);
           // newaccount.deposite(1000);
            newaccount.print();
            //newaccount.withdraw(200);
            newaccount.print();
            menuoptions options = readoptions();
            switch (options)
            {
                case menuoptions.deposite:
                    DoDeposit(newaccount);

                    break;
                case menuoptions.withdraw:
                    Dowithdraw(newaccount);

                    break;
                case menuoptions.print:
                    DoPrint(newaccount);

                    break;
                case menuoptions.quit:
                    //DoDeposit(newaccount);
                    Console.WriteLine("good bye");

                    break;
            }
        }
    }
}