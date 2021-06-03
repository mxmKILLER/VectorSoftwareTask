using System;
using System.Collections.Generic;
using System.Text;

namespace VectorSoftwareTask.OOP
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
            Area = Width * Height;
        }
        public double Height { get; set; }
        public double Width { get; set; }

    }
}