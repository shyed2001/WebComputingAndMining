using System;

namespace AccountClassLibrary
{
    public class Account
    {
        // Fields

        private int Id = 0;

        private double Balance = 0.0;

        private static double Balance2 = 4000.0; // for static property/accessors

        private double minBalance = 1000.0;

        private static double STATICminBalance = 1000.0; // for static property/accessors



        public Account()
        //default contructor, initializer
        {
            this.Id = 0;
            this.Balance = 0.0;

            // Id = 0;
            // Balance = 0.0;
            // int Id;
            // double Balance;

        }

        public Account(int id, double b)
        //  Parameterized Constructor, initializer
        {
            this.Id = id;
            this.Balance = b;

            //Id = id;
            //Balance = b;
        }

        public void setBalance(double amount) // setter method
        {
            if (Balance > minBalance)
            { this.Balance = amount; }
            //  { Balance = amount; }
        }

        public double getBalance() // getter method
        {
            return this.Balance;
        }



        public double p_Balance
        {
            get { return this.Balance; }
            set { if (Balance > minBalance) this.Balance = value; }
        }

        public static double static_p_Balance  // static property/accessors
        {
            get { return Balance2; }  // all the variables in a static property should be static
            set { if (Balance2 > STATICminBalance) Balance2 = value; }
        }


        public static double STATICminBalanceProperty // read only property
        {
            get { return STATICminBalance; }
        }
        public int AutoPropertyAccessorDemo // Auto Implemented property
        {
            // Auto/ self  Implemented property
            get; set;
            // compilier will assign a varible, we can return that value
        }



        // task 3 code
        private double[] Balance3;
        private int Size;

        public Account(int size) // arg constructor
        {
            this.Size = size;

            Balance3 = new double[this.Size];

        }
        // Task 3
        // indexers
        public double this[int index]
        { get
            {
                if (index >= 0 && index < this.Size)
                { return Balance3[index]; }
                else
                    return -2.0;
            }
            set
            {
                if (index >= 0 && index < this.Size)
                    Balance3[index] = value;
                else Console.WriteLine("Error in indexer");
            }


        }

        public double this[double index] // Overloaded indexer
        {
            get
            {
                if (index >= 0 && index < this.Size)
                { return Balance3[(int)index]; }
                else
                    return -2.0;
            }
            set
            {
                if (index >= 0 && index < this.Size)
                    Balance3[(int)index] = value;
                else Console.WriteLine("Error in indexer");
            }


        }

        // Show overloaded indexer to use an index as string

        string[] array = new string[] {"zero","one", "two", "three", "four", "five"};

        //public string name;
        
        public int this[string name]
        {
            get
            {
                for (int i = 0; i < 6; i++)
                {
                    if (array[i].ToLower() == name.ToLower())
                        return (int)Balance3[i];
                }

                return 0;
            }

        }




    }
}
