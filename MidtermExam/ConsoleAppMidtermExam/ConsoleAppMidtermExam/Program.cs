using System;


namespace MidExam_Answer
{
    public delegate string DlReplaceSpace(string str);
    public class Program
    {
        /*
         public static string ReplaceSpaces(string s)
         {
             Console.WriteLine("Replacing spaces with hyphens.");
             return s.Replace(' ', '-');
         }
        */
    }
    public class Test
    {
        public static void Main(String[] args)
        {
            string s = "Hello  ";

            DlReplaceSpace dlrs = (string str) =>
            {
                Console.WriteLine("Replacing spaces with hyphens.");
                return s.Replace(' ', '-');
            };

            Console.WriteLine(dlrs(s));
            // Console.WriteLine(Program.ReplaceSpaces(s));
        }
    }
}