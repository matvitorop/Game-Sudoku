using Classes.SudokuTypes;

namespace Classes.Visitor
{
    public class SudokuVisitor : IVisitor
    {
        private readonly Random _random = new();

        private void MakeCellsEmpty(Sudoku sudoku,int percentEmpty)
        {
            int size = sudoku.SudokuTable.GetLength(0);
            int totalCells = size * size;
            int cellsToEmpty = (int)(totalCells * (percentEmpty / 100.0));

            for (int i = 0; i < cellsToEmpty; i++)
            {
                int row = _random.Next(size);
                int col = _random.Next(size);
                if(sudoku.SudokuTable[row, col] != 0)
                {
                    sudoku.SudokuTable[row, col] = 0;
                }
            }
        }

        public void SudokuPrep<T>(T visitor) where T : Sudoku
        {
            MakeCellsEmpty(visitor, visitor.FillingDensity);
        }
    }
}
