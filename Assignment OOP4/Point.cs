﻿using System;
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










    }
}
