using Classes.Visitor;

namespace Classes.SudokuTypes
{
    public class SudokuSmall : Sudoku
    {
        public SudokuSmall(int fillDense) : base(fillDense)
        {
            SudokuTable = new int[4, 4];
            BlockSize = 2;
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.SudokuPrep(this);
        }
    }
}
