using System;
using System.Collections.Generic;
using System.Text;

namespace VectorSoftwareTask.OOP
{
    public class Triangle : Shape
    {
        public Triangle(double baze, double height)
        {
            Base = baze;
            Height = height;
            Area = Base * Height * 0.5;
        }

        public double Base { get; }
        public double Height { get; }

    }
}