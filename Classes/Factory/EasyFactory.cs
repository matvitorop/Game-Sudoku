using Classes.SudokuTypes;

namespace Classes.Factory
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
