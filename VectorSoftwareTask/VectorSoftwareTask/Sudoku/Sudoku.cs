using System;
using System.Collections.Generic;
using System.Linq;

namespace VectorSoftwareTask
{
    public class Sudoku
    {
        private const int DEFAULT_SIZE = 9;
        private int[,] body;
        private readonly int size;
        public Sudoku(int size)
        {
            body = new int[size, size];
            this.size = size;
            PopulateWithZero();
        }

        public Sudoku()
        {
            size = DEFAULT_SIZE;
            PopulateDefault();
        }

        private void PopulateWithZero()
        {

            for (int i = 0; i > size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    body[i, j] = 0;
                }
                Console.WriteLine();
            }
        }

        private void PopulateDefault()
        {

            this.body = new int[DEFAULT_SIZE, DEFAULT_SIZE] {
                { 7, 8, 4, 1, 5, 9, 3, 2, 6},
                { 5, 3, 9, 6, 7, 2, 8, 4, 1},
                { 6, 1, 2, 4, 3, 8, 7, 5, 9},
                { 9, 2, 8, 7, 1, 5, 4, 6, 3},
                { 3, 5, 7, 8, 4, 6, 1, 9, 2},
                { 4, 6, 1, 9, 2, 3, 5, 8, 7},
                { 8, 7, 6, 3, 9, 4, 2, 1, 5},
                { 2, 4, 3, 5, 6, 1, 9, 7, 8},
                { 1, 9, 5, 2, 8, 7, 6, 3, 4} };
        }

        public void PopulateDefault16()
        {

            this.body = new int[16, 16] {
                { 4, 10, 9, 15, 1, 7, 13, 8, 6, 14, 2, 12, 16, 5, 3, 11},
                { 2, 5, 3, 1, 15, 4, 11, 16, 13, 9, 8, 7, 6, 10, 12, 14},
                { 14, 6, 13, 12, 3, 10, 5, 2, 16, 11, 1, 4, 8, 15, 9, 7},
                { 11, 7, 16, 8, 6, 14, 9, 12, 5, 3, 10, 15, 1, 2, 13, 4},
                { 8, 16, 11, 4, 13, 15, 14, 9, 2, 5, 7, 3, 12, 1, 10, 6},
                { 1, 14, 6, 13, 12, 8, 4, 5, 10, 16, 9, 11, 2, 3, 7, 15},
                { 10, 15, 5, 3, 2, 1, 6, 7, 4, 12, 14, 8, 9, 11, 16, 13},
                { 12, 2, 7, 9, 11, 3, 16, 10, 15, 13, 6, 1, 4, 8, 14, 5},
                { 9, 4, 1, 10, 14, 2, 3, 13, 11, 15, 12, 6, 7, 16, 5, 8},
                { 5, 8, 14, 16, 7, 9, 1, 6, 3, 4, 13, 10, 11, 12, 15, 2},
                { 7, 3, 15, 6, 16, 11, 12, 4, 8, 2, 5, 9, 14, 13, 1, 10},
                { 13, 12, 2, 11, 10, 5, 8, 15, 7, 1, 16, 14, 3, 6, 4, 9},
                { 15, 9, 8, 2, 4, 12, 7, 3, 1, 10, 11, 13, 5, 14, 6, 16},
                { 6, 13, 12, 5, 9, 16, 15, 1, 14, 8, 4, 2, 10, 7, 11 ,3},
                { 16, 11, 4, 7, 8, 13, 10, 14, 12, 6, 3, 5, 15, 9, 2, 1},
                { 3, 1, 10, 14, 5, 6, 2, 11, 9, 7, 15, 16, 13, 4, 8, 12}
            };

        }

        public void ConsoleDisplay()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(body[i, j]);

                    if (j != size - 1)
                    {
                        Console.Write(",");
                    }
                    if ((j + 1) % Math.Sqrt(size) == 0)
                    {
                        Console.Write(" ");
                    }
                }
                if ((i + 1) % Math.Sqrt(size) == 0)
                {
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public static bool IsSudokuValid(Sudoku sudoku)
        {
            List<int[]> arrays = new List<int[]>();
            PopulateRowArrays(sudoku, arrays);
            PopulateColArrays(sudoku, arrays);
            PopulateSqureArrays(sudoku, arrays);

            foreach (var item in arrays)
            {
                if (item.Distinct().Count() != sudoku.size)
                {
                    return false;
                }
            }
            return true;
        }

        private static void PopulateSqureArrays(Sudoku sudoku, List<int[]> arrays)
        {
            int[,] arr1 = new int[sudoku.size, sudoku.size];
            for (int i = 0; i < sudoku.size; i++)
            {
                int square = (int)Math.Sqrt(sudoku.size);
                for (int j = 0; j < sudoku.size; j++)
                {
                    arr1[square * (i / square) + (j / square), square * (i % square) + (j % square)] = sudoku.body[i, j];
                }
            }

            for (int i = 0; i < sudoku.size; i++)
            {
                int[] arr = new int[sudoku.size];
                for (int j = 0; j < sudoku.size; j++)
                {
                    arr[j] = arr1[i, j];
                }
                arrays.Add(arr);
            }
        }

        private static void PopulateColArrays(Sudoku sudoku, List<int[]> arrays)
        {
            for (int i = 0; i < sudoku.size; i++)
            {
                int[] arr = new int[sudoku.size];
                for (int j = 0; j < sudoku.size; j++)
                {
                    arr[j] = sudoku.body[j, i];
                }
                arrays.Add(arr);
            }
        }

        private static void PopulateRowArrays(Sudoku sudoku, List<int[]> arrays)
        {
            for (int i = 0; i < sudoku.size; i++)
            {
                int[] arr = new int[sudoku.size];
                for (int j = 0; j < sudoku.size; j++)
                {
                    arr[j] = sudoku.body[i, j];
                }
                arrays.Add(arr);
            }
        }
    }
}
