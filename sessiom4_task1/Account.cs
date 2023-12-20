using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace sessiom4_task1
{
   
    internal class Account
    {


        double balance;
        string name;
      
        public Account(string _name, double _balance)
        {
            name = _name;
            balance = _balance;


           



        }
        //public void deposite(double amount)

        //{
        //    balance += amount;

        //}
        public void dodeposite(Account account)
        {
            //  balance += amount;

            Console.WriteLine("enter yr account");
            int amount = Convert.ToInt32(Console.ReadLine());

            if (amount < 0)
            {

                balance += amount;
                Console.WriteLine("done");

            }
            Console.WriteLine("failed");


        }
        //public void withdraw(double amount)

        //{
        //    balance -= amount;

        //}
        public void dowithdraw(Account account)

        {
            Console.WriteLine("enter yr account");
            int amount = Convert.ToInt32(Console.ReadLine());

            if (amount < balance && amount > 0)
            {

                balance += amount;
                Console.WriteLine("done");

            }
            Console.WriteLine("failed");

        }
        public void doprint(Account account)
        {
            Console.WriteLine(balance);
            Console.WriteLine(name);
        }


        public void print()
        {
            Console.WriteLine(balance);
            Console.WriteLine(name);

        }
        public bool deposite(int amount)
        {
            if(amount   > 0)
            {

                   balance += amount;
                return true;

            }
            return false;
        }
        public bool withdraw(int amount)
        {
            if (amount < balance && amount >0)
            {

                balance -= amount;
                return true;

            }
            return false;
        }


     




    }
}
