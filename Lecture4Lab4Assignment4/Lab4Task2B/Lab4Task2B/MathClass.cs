using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab4Task2B
{
    public delegate int pointerFunction(int x, int y);

    public class MathClass
    {
        // public static int Add(int x , int y)
        private static int Add(int x, int y)
        {
            return x + y;
        }
        // public static int Sub(int x, int y)
        private static int Sub(int x, int y)
        {
            return x - y;
        }

        // de coupling the functions
        //public static int getPointer(int operation, int number1, int number2)
        //{
        //    //pointerFunction pf = null;
        //    if (operation == 1)
        //    {
        //        //pf = Add; //add can be private as well
        //        return Add(number1, number2);
        //    }

        //    else if (operation == 2)
        //    {
        //        // pf = Sub; //sub can be private as well
        //        return Sub(number1, number2);
        //    }


        //    else return 0;

        //    //return pf;

        // }

       // loosely coupled code
        /*  public static pointerFunction getPointer(int operation)
          {
              pointerFunction pf = null;
              if (operation == 1)
                  pf = Add; //add can be private as well
              else if (operation == 2)
                  pf = Sub; //sub can be private as well

              return pf;
          }
          */
        /* 
         annonimus class/delegates
          public static pointerFunction getPointer(int operation)
          {
              pointerFunction pf = null;
              if (operation == 1)
                  pf = delegate (int x, int y)
                  {
                      return x + y;
                  };

              else if (operation == 2)
                  pf = delegate (int x, int y)
                  {
                      return x - y;
                  };

              return pf;
          }





          */
        // lamda expression
        public static pointerFunction getPointer(int operation)
        {
            pointerFunction pf = null;
            if (operation == 1)
                pf = (int x, int y)=>
                {
                    return x + y;
                };

            else if (operation == 2)
                pf = (int x, int y) => x - y;

            return pf;
        }
    }


}