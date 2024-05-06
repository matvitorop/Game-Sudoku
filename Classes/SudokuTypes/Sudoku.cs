using System;
using System.Drawing;
using Classes.Visitor;

namespace Classes.SudokuTypes
{
    public abstract class Sudoku
    {
        Random random = new Random();

        public int[] calculationArray;

        public int[,] sudokuTable;

        public int fillingDensity;

        int size;

        public int blockSize;

        public Sudoku(int fillDens)
        {
            fillingDensity = fillDens;
        }
        public void GenerateSudoku()
        {
            FillFirstRow();
            FillRemaining();
        }

        public bool IsValidInsert(int row, int col, int num)
        {
            for (int i = 0; i < sudokuTable.GetLength(0); i++)
            {
                if (sudokuTable[row, i] == num || sudokuTable[i, col] == num)
                {
                    return false;
                }
            }


            int startRow = row / blockSize * blockSize;
            int startCol = col / blockSize * blockSize;

            for (int i = startRow; i < startRow + blockSize; i++)
            {
                for (int j = startCol; j < startCol + blockSize; j++)
                {
                    if (sudokuTable[i, j] == num)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public void FillFirstRow()
        {
            size = sudokuTable.GetLength(0);

            List<int> numbers = Enumerable.Range(1, size).ToList();

            Shuffle(numbers);

            for (int i = 0; i < size; i++)
            {
                sudokuTable[0, i] = numbers[i];
            }
        }

        public List<T> Shuffle<T>(List<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return list;
        }

        public bool FillRemaining()
        {
            int row = -1;
            int col = -1;
            bool isEmpty = true;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (sudokuTable[i, j] == 0)
                    {
                        isEmpty = false;
                        row = i;
                        col = j;
                        break;
                    }
                }
                if (!isEmpty)
                {
                    break;
                }
            }

            if (isEmpty)
            {
                return true;
            }
            List<int> numbers = Enumerable.Range(1, size).ToList();

            Shuffle(numbers);

            foreach (int i in numbers)
            {
                if (IsValidInsert(row, col, i))
                {
                    sudokuTable[row, col] = i;
                    if (FillRemaining())
                    {
                        return true;
                    }
                    sudokuTable[row, col] = 0;
                }
            }
            return false;
        }

        public abstract void Accept(IVisitor visitor);
    }
}
