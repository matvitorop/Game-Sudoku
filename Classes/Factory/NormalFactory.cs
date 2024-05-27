using Classes.SudokuTypes;

namespace Classes.Factory
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
