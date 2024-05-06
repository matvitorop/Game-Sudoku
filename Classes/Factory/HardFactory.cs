using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.SudokuTypes;

namespace Classes.Factory
{
    public class HardFactory : ISudokuFactory
    {
        public Sudoku CreateBigSudoku()
        {
            return new SudokuBig(50);
        }

        public Sudoku CreateMediumSudoku()
        {
            return new SudokuMedium(50);
        }

        public Sudoku CreateSmallSudoku()
        {
            return new SudokuSmall(50);
        }
    }
}
