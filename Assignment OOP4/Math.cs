using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP4
{
    internal class Math
    {
        #region 1.Define Class Maths that has four methods: Add, Subtract, Multiply, and Divide, each of them takes two parameters. Call each method in Main ().
        //public int Add(int x, int y)
        //{
        //	return x + y;
        //}
        //public int sub(int x,int y)
        //{
        //	return x - y;
        //}
        //public int mul (int x,int y)
        //{
        //	return x * y;
        //}
        //public int Div(int x, int y)
        //{
        //	if (y==0)
        //		return 0;
        //	return x / y;
        //}


        #endregion
        #region 2. Modify the program so that you do not have to create an instance of class to call the four methods.
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int sub(int x, int y)
        {
            return x - y;
        }
        public static int mul(int x, int y)
        {
            return x * y;
        }
        public static int Div(int x, int y)
        {
            if (y == 0)
                return 0;
            return x / y;
        }





        #endregion
    }
}
