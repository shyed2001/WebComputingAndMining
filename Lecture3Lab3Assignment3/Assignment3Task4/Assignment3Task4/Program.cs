using System;
using System.Collections.Generic; // i had to add this line no 2

namespace Assignment3Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            Console.WriteLine("Task 4");

            Department d = new Department();

            Console.WriteLine("1st Student is " + d[1]);
            Console.WriteLine("2nd Student is " + d[2]);
            Console.WriteLine("3rd Student is " + d[3]);

            d[1] = "Zara";

            d[2] = "Rahim";
            d[3] = "Karim";

            Console.WriteLine("After Changing the Value\n");

            Console.WriteLine("1st Student is " + d[1]);
            Console.WriteLine("2nd Student is " + d[2]);
            Console.WriteLine("3rd Student is " + d[3]);

        }

    }

    class Department  // class with List collection
    {
        List<Student> studentlist;

        //public Department() // i had to add lines 41-44
        //{

        //}

        //public Department(List<Student> studentlist)
             public Department()
        {
            studentlist = new List<Student>();

            Student s1 = new Student();

            s1.Id = 1; s1.Name = "Rahim"; s1.Address = "Uttara";

            studentlist.Add(s1);

            Student s2 = new Student();
            s2.Id = 2; s2.Name = "Karim"; s2.Address = "Mirpur";
            studentlist.Add(s2);

            Student s3 = new Student();
            s3.Id = 3; s3.Name = "Zara"; s3.Address = "Gulshan";
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
//using System;
//using System.Collections.Generic;
//namespace Lab3Task4
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Department d = new Department();
//            Console.WriteLine("1st Student is " + d[1]);
//            Console.WriteLine("2nd Student is " + d[2]);
//            Console.WriteLine("3rd Student is " + d[3]);
//            d[1] = "Zara";
//            d[2] = "Md Ebrahim Hossain";
//            d[3] = "Rahim";
//            Console.WriteLine("After Changing the Value\n");
//            Console.WriteLine("1st Student is " + d[1]);
//            Console.WriteLine("2nd Student is " + d[2]);
//            Console.WriteLine("3rd Student is " + d[3]);
//        }
//    }
//    class Department
//    {
//        List<Student> studentlist;
//        public Department()
//        {
//            studentlist = new List<Student>();
//            Student s1 = new Student();
//            s1.Id = 1; s1.Name = "Md Ebrahim Hossain"; s1.Address = "Chattagram";
//            studentlist.Add(s1);
//            Student s2 = new Student();
//            s2.Id = 2; s2.Name = "Rahim"; s2.Address = "Mirpur";
//            studentlist.Add(s2);
//            Student s3 = new Student();
//            s3.Id = 3; s3.Name = "Zara"; s3.Address = "Gulshan";
//            studentlist.Add(s3);
//            //studentlist.Add(new Student() { Id = 2, Name = "Rahim", Address = "Uttara" });
//            //studentlist.Add(new Student() { Id = 3, Name = "Karim", Address = "Mirpur" });
//        }
//        public string this[int index]
//        {
//            get { return studentlist.Find(Student => Student.Id == index).Name; }
//            set { studentlist.Find(Student => Student.Id == index).Name = value; }
//        }
//    }
//    class Student
//    {
//        public int Id { get; set; }
//        public String Name { get; set; }
//        public String Address { get; set; }
//    }
//}