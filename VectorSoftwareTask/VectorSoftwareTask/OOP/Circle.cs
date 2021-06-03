using System;
using System.Collections.Generic;
using System.Text;

namespace VectorSoftwareTask.OOP
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
            Area = Radius * Math.PI;
        }

        public double Radius { get; }

    }
}