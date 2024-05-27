using Classes.Visitor;

namespace Classes.SudokuTypes
{
    public class SudokuMedium : Sudoku
    {
        public SudokuMedium(int fillDense) : base(fillDense)
        {
            SudokuTable = new int[9, 9];
            BlockSize = 3;
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.SudokuPrep(this);
        }
    }
}
