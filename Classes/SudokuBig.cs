using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class SudokuBig : Sudoku
    {
        public SudokuBig(int fillDense) : base(fillDense)
        {
            sudokuTable = new int[16, 16];
            blockSize = 4;
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.FillAndPrep(this);
        }
    }
}
