using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class NormalFactory : ISudokuFactory
    {
        public Sudoku CreateBigSudoku()
        {
            return new SudokuBig(35);
        }

        public Sudoku CreateMediumSudoku()
        {
            return new SudokuMedium(35);
        }

        public Sudoku CreateSmallSudoku()
        {
            return new SudokuSmall(35);
        }
    }
}
