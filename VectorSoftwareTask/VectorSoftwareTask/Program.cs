using System;
using System.Collections.Generic;
using VectorSoftwareTask.OOP;

namespace VectorSoftwareTask
{
    class Program
    {

        static void Main(string[] args)
        {
            SudokuTask();
            OOPTask();
        }

        private static void OOPTask()
        {
            var side = 1.1234D;
            var radius = 1.1234D;
            var baze = 5D;
            var height = 2D;
            var shapes = new List<Shape>{ new Square(side),
            new Circle(radius),
            new Triangle(baze, height) };
            shapes.Sort();

            foreach (var item in shapes)
            {
                Console.WriteLine(item.Area + "\n" + item.ToString());
            }
        }

        private static void SudokuTask()
        {
            Sudoku s1 = new Sudoku() { };
            s1.ConsoleDisplay();
            if (Sudoku.IsSudokuValid(s1))
                Console.WriteLine("Sudoku is valid");
            else
                Console.WriteLine("Sudoku is invalid");
        }
    }
}