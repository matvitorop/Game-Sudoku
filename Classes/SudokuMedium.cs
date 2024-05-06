using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class SudokuMedium: Sudoku
    {
        public SudokuMedium(int fillDense) : base(fillDense)
        {
            sudokuTable = new int[9, 9];
            blockSize = 3;
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.FillAndPrep(this);
        }
    }
}
