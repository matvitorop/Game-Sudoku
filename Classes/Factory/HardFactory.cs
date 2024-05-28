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
