using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP4
{
    internal class Demo
    {
        internal class Rectangle : Shape
        {
            public override double Perimeter
            {
                get
                {
                    return (Dim01 + Dim02) * 2;
                }
            }

            public override double GetArea()
            {
                return Dim02 * Dim01;


            }


            public double Dim01 { get; set; }
            public double Dim02 { get; set; }

            // Abstract Method 
            public abstract double GetArea();

            // Abstract Property
            public abstract double Perimeter { get; }


            public void Print()
            {
                Console.WriteLine("I am Shape");
            }
        }
    }

}
