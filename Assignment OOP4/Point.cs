using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_OOP4
{
    internal class Point

    {
        #region Q1

        //1.Define 3D Point Class and the basic Constructors(use chaining in constructors).

        #region Attributes

        private int x;
        private int y;
        private int z;
        #endregion

        #region Properties

        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        public int Z { get { return z; } set { z = value; } }
        #endregion

        #region Constructors

        public Point3D(int _x, int _y, int _z)
        {
            x = _x;
            y = _y;
            z = _z;

        }
        public Point3D(int _x, int _y) : this(_x, _y, 0)
        {


        }
        public Point3D(int _x) : this(_x, 0, 0)
        {


        }

        #endregion

        #endregion

        #region Q2
        //2.Override the ToString Function to produce this output:
		//  Point3D P = new Point3D(10, 10, 10);
		//  Console.WriteLine(P.ToString( ));
		//  Output: “Point Coordinates: (10, 10, 10)”.
		public override string ToString()
        {
            return $"Point Coordinates:{x},{y},{z}";
        }








        #endregion

        #region Q3
         //3. Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).

		#region CreatePoint
		public static Point3D Create3Dpoint()
    {
        int x, y, z;
        bool flag;
        do
        {
            Console.WriteLine("X");
            flag = int.TryParse(Console.ReadLine(), out x);

        } while (!flag);
        do
        {
            Console.WriteLine("Y");
            flag = int.TryParse(Console.ReadLine(), out y);

        } while (!flag);
        do
        {
            Console.WriteLine("Z");
            flag = int.TryParse(Console.ReadLine(), out z);

        } while (!flag);
        return new Point3D(x, y, z);
        }


        #endregion
        #endregion


        #region Q4
       //4.Try to use == If(P1 == P2)   Does it work properly? 
        /* == operator compare ref of objects if i want to 
          To compare objects for their values so you have to 
         overload ==  and != operators  
        Or override Equals() and GetHashcode() methods */
        public static bool operator ==(Point3D p1, Point3D p2)
        {
            return p1.x == p2.x && p1.y == p2.y && p1.z == p2.z;
        }
        public static bool operator !=(Point3D p1, Point3D p2)
        {

            return p1.x != p2.x || p1.y != p2.y || p1.z != p2.z;
        }


        #endregion

       
         #region Q5
        //5.Sort Array based on X & Y Coordinates

        public static void sortarray(Point3D[] arr)
        {
            Array.Sort(arr);
        }

        public int CompareTo(object? obj)
        {
            Point3D point = (Point3D)obj;
            if (x > point.x)
                return 1;
            else if (x < point.x)
                return -1;
            else
            {
                if (y > point.y)
                    return 1;
                else if (y < point.y)
                    return -1;
                else
                {
                    if (z > point.z)
                        return 1;
                    else if (z < point.z)
                        return -1;
                    return 0;
                }
            }

        }
        #endregion
        


        











    }
}
