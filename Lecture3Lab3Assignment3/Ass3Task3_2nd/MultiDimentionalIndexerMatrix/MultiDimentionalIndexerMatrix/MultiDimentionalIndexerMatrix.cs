using System;
namespace MultiDimentionalIndexerMatrix
{
    class MultiDimentionalIndexerMatrix
    {
        class MultiDimensional
        {
            private string[,] _guideNames = new string[10, 10];

            public string this[int x, int y]
            {
                get { return _guideNames[x, y]; }
                set { _guideNames[x, y] = value; }
            }
        }
        static void Main(string[] args)
        {
            MultiDimensional theMatrix = new MultiDimensional();
            theMatrix[0, 0] = "Shyed";
            theMatrix[0, 1] = "Shahriar";
            theMatrix[0, 2] = "Housaini";
            theMatrix[1, 0] = "MCE 079 05536";
            theMatrix[2, 0] = "Assignment 3";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (theMatrix[i, j] == null) 
                            { Console.Write("N/A "); }
                    else
                            { Console.Write($"{theMatrix[i, j]} "); }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
