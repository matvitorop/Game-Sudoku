using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.SudokuTypes;

namespace Classes.Factory
{
    public interface ISudokuFactory
    {
        public Sudoku CreateSmallSudoku();
        public Sudoku CreateMediumSudoku();
        public Sudoku CreateBigSudoku();
    }
}
