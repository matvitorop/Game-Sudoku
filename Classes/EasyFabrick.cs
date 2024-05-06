using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class EasyFactory : ISudokuFactory
    {
        public Sudoku CreateBigSudoku()
        {
            return new SudokuBig(15);
        }

        public Sudoku CreateMediumSudoku()
        {
            return new SudokuMedium(15);
        }

        public Sudoku CreateSmallSudoku()
        {
            return new SudokuSmall(15);
        }
    }
}
