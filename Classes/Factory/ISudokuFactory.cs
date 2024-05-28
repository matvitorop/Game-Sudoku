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
