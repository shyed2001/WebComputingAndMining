using System;

namespace Assignment3ClassMembersPropertiesConsoleApp
{

    public class Account
    {

        private int Id;

        private double Balance;

        private double minBalance = 1000.0;

        public Account()
        //default contructor
         {
            this.Id = 0;
            this.Balance = 0.0;

        }


        public Account(int id , double b) // optional default values
        // decalaring Paremetrized Constructor with ing x,y parameter   
        {
            this.Id = id; 
            this.Balance = b;
            }

        public void setBalance( double amount)
            { 
            if (Balance > minBalance)
            { this.Balance = amount; }
        } 

        public double getBalance()
        {
            return this.Balance;
        }
    }

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello World!");
            
    //        Account First_account = new Account();
    //        Console.WriteLine("Balance now is " + First_account.getBalance());
    //        First_account.setBalance(100);
    //        Console.WriteLine("Balance now is " + First_account.getBalance());
    //        First_account.setBalance(1000);
    //        // First_account.getBalance();
    //        Console.WriteLine("Balance now is " + First_account.getBalance());

    //        Console.WriteLine(" First_account Balance is " + First_account.Balance );
    //        First_account.Balance = 100;
    //        Console.WriteLine(" First_account Balance is " + First_account.Balance);
    //        First_account.Balance = 10000;
    //        Console.WriteLine(" First_account Balance is " + First_account.Balance);
    //        Console.WriteLine("Balance now is " + First_account.getBalance());
    //        Console.WriteLine(" First_account ID is " + First_account.ID);
    //        First_account.ID = 550;
    //        Console.WriteLine(" First_account ID is " + First_account.ID);
    //    }
    //}
}
