using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace VectorSoftwareTask.OOP
{
    public class Square : Shape
    {
        public Square(double side)
        {
            Side = side;
            Area = Math.Pow(Side, 2);
        }

        public double Side { get; set; }

    }
}