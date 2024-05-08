using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.SudokuTypes;

namespace Classes.Visitor
{
    public class SudokuVisitor : IVisitor
    {
        private Random random = new Random();
        public void MakeCellsEmpty(Sudoku sudoku,int percentEmpty)
        {
            int size = sudoku.sudokuTable.GetLength(0);
            int totalCells = size * size;
            int cellsToEmpty = (int)(totalCells * (percentEmpty / 100.0));

            for (int i = 0; i < cellsToEmpty; i++)
            {
                int row = random.Next(size);
                int col = random.Next(size);
                if(sudoku.sudokuTable[row, col] != 0)
                {
                    sudoku.sudokuTable[row, col] = 0;
                }
                else
                {
                    continue;
                }
                
            }
        }

        public void SudokuPrep(SudokuSmall visitor)
        {
            MakeCellsEmpty(visitor, visitor.fillingDensity);
        }

        public void SudokuPrep(SudokuMedium visitor)
        {
            MakeCellsEmpty(visitor, visitor.fillingDensity);
        }

        public void SudokuPrep(SudokuBig visitor)
        {
            MakeCellsEmpty(visitor, visitor.fillingDensity);
        }
    }
}
