using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace VectorSoftwareTask.OOP
{
    public class Shape : IEquatable<Shape>, IComparable<Shape>
    {
        public double Area { get; set; }

        public int CompareTo(Shape other)
        {
            if (other == null)
                return 1;

            else
                return this.Area.CompareTo(other.Area);
        }

        public bool Equals(Shape other)
        {
            if (other == null) return false;
            return (this.Area.Equals(other.Area));
        }
    }
}