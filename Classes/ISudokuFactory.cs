using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public interface ISudokuFactory
    {
        public Sudoku CreateSmallSudoku();
        public Sudoku CreateMediumSudoku();
        public Sudoku CreateBigSudoku();
    }
}
