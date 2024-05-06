using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.SudokuTypes;

namespace Classes.Visitor
{
    public class SudokuVisitor : IVisitor
    {
        public void FillAndPrep(SudokuSmall visitor)
        {
            Console.WriteLine("Checking small sudoku");
        }

        public void FillAndPrep(SudokuMedium visitor)
        {
            Console.WriteLine("Checking medium sudoku");
        }

        public void FillAndPrep(SudokuBig visitor)
        {
            Console.WriteLine("Checking big sudoku");
        }
    }
}
