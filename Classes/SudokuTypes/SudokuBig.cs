using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Visitor;

namespace Classes.SudokuTypes
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
            visitor.SudokuPrep(this);
        }
    }
}
