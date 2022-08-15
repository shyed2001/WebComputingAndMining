    using System;
    using AccountClassLibrary;
    using System.Collections.Generic;

namespace Assignment3Lab3Taskb
{
    class PropertiesIndexersListCollection
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shyed Shahriar Housaini , MCE 079 05538 \n");
            Console.Write("Task 1 ");
            Console.WriteLine(" Properties : ");
            Account account = new Account(11, 5555);
            Console.WriteLine("Balance Before change " + account.getBalance());
            account.setBalance(10000);
            Console.WriteLine(" Balance After change " + account.getBalance());

            Console.WriteLine("Task 2");
            account.p_Balance = 7777;
            Console.WriteLine(" Balance After change from property " + account.p_Balance);
            Account.static_p_Balance = 3333333;
            Console.WriteLine(" Balance After change from static property " + Account.static_p_Balance);
            Console.WriteLine(" Static property and static methods can only have static variables, so all the variables in a static property should be static");
            Console.WriteLine(" Static variable for static property Minimum balance is = " + Account.STATICminBalanceProperty);

            // Account.STATICminBalanceProperty = 2000.0;

            Console.WriteLine("Can not change read Only static variable minimum balance ");

            account.AutoPropertyAccessorDemo = 111111;
            Console.WriteLine("Value set to Auto Implemented property = " + account.AutoPropertyAccessorDemo);

            // indexers, class objects as arrays.
            Console.WriteLine("Indexers, class objects as arrays : ");

            // Task 3

            Console.Write (" Over loaded indexer ");
            Console.Write("Task 3 \n");

            Account account3 = new Account(6);

            account3[0] = 2.0;
            account3[1] = 4.0;
            account3[2] = account3[1] + account3[0];
            account3[3] = 8.0;
            account3[4] = 10.0;
            account3[6] = 12.0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(account3[i]);
            }


                  

            Console.Write("Task 4 ");

            Console.WriteLine("Class with List collection \n");

            Department d = new Department();

 

        Console.WriteLine("1st Student is " + d[1]);
            Console.WriteLine("2nd Student is " + d[2]);
            Console.WriteLine("3rd Student is " + d[3]);

            d[1] = "Zara";
            d[2] = "Rahim";
            d[3] = "Karim";

            Console.WriteLine("\n After Changing the Value\n");

            Console.WriteLine("1st Student is " + d[1]);
            Console.WriteLine("2nd Student is " + d[2]);
            Console.WriteLine("3rd Student is " + d[3]);
            Console.ReadKey();
            Console.WriteLine("Shyed Shahriar Housaini , MCE 079 05538 \n");
        }



        //    // Over loaded indexer


        String[] array = new string[] { "zero", "one", "two", "three", "four", "five" };

        public int Balance { get; set; }
        public int this[string name]
        {
            get
            {
                for (int i = 0; i < 6; i++)
                {
                    if (array[i].ToLower() == name.ToLower())

                        return Balance;

                }
                return 0;
            }
        }
    }

    // Task 4

    class Department  // class with List collection
    {
        List<Student> studentlist;


             public Department()
        {
                studentlist = new List<Student>();

                Student s1 = new Student();

                s1.Id = 1; s1.Name = "Shyed"; s1.Address = "Dhaka";

                studentlist.Add(s1);

                Student s2 = new Student();
                s2.Id = 2; s2.Name = "Shahriar"; s2.Address = "Sylhet";
                studentlist.Add(s2);

                Student s3 = new Student();
                s3.Id = 3; s3.Name = "Housaini"; s3.Address = "Chittagong";
                studentlist.Add(s3);


                //studentlist. Add(new Student() { Id=1, Name="Rahim", Address="Uttara" });
                // studentlist.Add(new Student() { Id = 2, Name = "Kahim", Address = "Mirpur" });
                // studentlist.Add(new Student() { Id = 3, Name = "Zara", Address = "Gulshan" });

        }

            public string this[int index]
            {
                get { return studentlist.Find(Student => Student.Id == index).Name; }
                set { studentlist.Find(Student => Student.Id == index).Name = value; }
            }


    }

    class Student // Task 4 a
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public String Address { get; set; }

    }

}
