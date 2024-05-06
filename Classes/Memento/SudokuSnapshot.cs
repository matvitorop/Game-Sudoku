using Classes.SudokuTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Memento
{
    public class SudokuSnapshot : ISnapshot
    {
        public int[,] SudokuState { get; }
        
        public DateTime creationDate { get; } = DateTime.Now;
        
        public SudokuSnapshot(int[,] sudokuState)
        {
            SudokuState = (int[,])sudokuState.Clone();
        }
        
        public int[,] GetState()
        {
            return SudokuState;
        }
    }
}
