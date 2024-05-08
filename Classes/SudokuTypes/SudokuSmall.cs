using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Visitor;

namespace Classes.SudokuTypes
{
    public class SudokuSmall : Sudoku
    {
        public SudokuSmall(int fillDense) : base(fillDense)
        {
            sudokuTable = new int[4, 4];
            blockSize = 2;
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.SudokuPrep(this);
        }
    }
}
