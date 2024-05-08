using System;
using System.Drawing;
using Classes.Visitor;
using Classes.Memento;

namespace Classes.SudokuTypes
{
    public abstract class Sudoku
    {

        public int[] calculationArray;

        public int[,] sudokuTable { get; set; }

        public int fillingDensity;

        public int size;

        public int blockSize;

        public Sudoku(int fillDens)
        {
            fillingDensity = fillDens;
        }

        public abstract void Accept(IVisitor visitor);
        
        public ISnapshot Save()
        {
            return new SudokuSnapshot(sudokuTable);
        }
        public void Restore(ISnapshot snapshot)
        {
            if (snapshot is SudokuSnapshot)
            {
                var memento = (SudokuSnapshot)snapshot;
                sudokuTable = memento.GetState();
            }
            else
            {
                throw new ArgumentException("Wrong type of snapshot");
            }
        }

    }
}
