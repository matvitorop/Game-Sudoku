using Classes.Visitor;
using Classes.Memento;

namespace Classes.SudokuTypes
{
    public abstract class Sudoku(int fillDens)
    {
        public int[,] SudokuTable { get; set; } = null!;

        public readonly int FillingDensity = fillDens;

        public int Size;

        public int BlockSize;

        public abstract void Accept(IVisitor visitor);
        public ISnapshot Save()
        {
            return new SudokuSnapshot(SudokuTable);
        }
        public void Restore(ISnapshot snapshot)
        {
            if (snapshot is SudokuSnapshot)
            {
                var memento = (SudokuSnapshot)snapshot;
                SudokuTable = memento.GetState();
            }
            else
            {
                throw new ArgumentException("Wrong type of snapshot");
            }
        }
    }
}
