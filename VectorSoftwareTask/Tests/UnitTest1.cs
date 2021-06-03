using System;
using Xunit;
using VectorSoftwareTask;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void IsValidTest()
        {
            Sudoku sudoku = new Sudoku();

            bool result = Sudoku.IsSudokuValid(sudoku);

            Assert.True(result);
        }

        [Fact]
        public void Is16ValidTest()
        {
            Sudoku sudoku = new Sudoku(16);

            sudoku.PopulateDefault16();

            bool result = Sudoku.IsSudokuValid(sudoku);

            Assert.True(result);
        }
    }
}
