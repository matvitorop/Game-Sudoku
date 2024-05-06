﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class SudokuSmall: Sudoku
    {
        public SudokuSmall(int fillDense) : base(fillDense) 
        {
            sudokuTable = new int[4,4];
            blockSize = 2;
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.FillAndPrep(this);
        }
    }
}
