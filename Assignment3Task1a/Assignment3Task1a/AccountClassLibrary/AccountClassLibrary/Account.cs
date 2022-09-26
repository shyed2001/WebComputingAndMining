using System;

namespace AccountClassLibrary
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

        public Account(int id, double b) 
        {
            this.Id = id;
            this.Balance = b;
        }

        public void setBalance(double amount)
        {
            if (Balance > minBalance)
            { this.Balance = amount; }
        }

        public double getBalance()
        {
            return this.Balance;
        }
    }
}
