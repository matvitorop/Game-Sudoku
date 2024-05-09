using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.SudokuTypes
{
    sealed public class SudokuService
    {
        private static SudokuService _instance;
        private Random random = new Random();
        private Sudoku sudokuToChange;

        private SudokuService()
        {
            // Приватний конструктор для запобігання створенню екземплярів ззовні.
        }

        public static SudokuService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SudokuService();
                }
                return _instance;
            }
        }

        public void SetSudoku(Sudoku sudoku)
        {
            sudokuToChange = sudoku;
        }

        public void GenerateSudoku()
        {
            FillFirstRow();
            FillRemaining();
        }

        public void RecoveringCells()
        {
            FillRemaining();
        }

        public bool IsValidInsert(int row, int col, int num)
        {
            for (int i = 0; i < sudokuToChange.sudokuTable.GetLength(0); i++)
            {
                if (sudokuToChange.sudokuTable[row, i] == num || sudokuToChange.sudokuTable[i, col] == num)
                {
                    return false;
                }
            }

            int startRow = row / sudokuToChange.blockSize * sudokuToChange.blockSize;
            int startCol = col / sudokuToChange.blockSize * sudokuToChange.blockSize;

            for (int i = startRow; i < startRow + sudokuToChange.blockSize; i++)
            {
                for (int j = startCol; j < startCol + sudokuToChange.blockSize; j++)
                {
                    if (sudokuToChange.sudokuTable[i, j] == num)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public void FillFirstRow()
        {
            sudokuToChange.size = sudokuToChange.sudokuTable.GetLength(0);

            List<int> numbers = Enumerable.Range(1, sudokuToChange.size).ToList();
            Shuffle(numbers);

            for (int i = 0; i < sudokuToChange.size; i++)
            {
                sudokuToChange.sudokuTable[0, i] = numbers[i];
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
            for (int i = 0; i < sudokuToChange.size; i++)
            {
                for (int j = 0; j < sudokuToChange.size; j++)
                {
                    if (sudokuToChange.sudokuTable[i, j] == 0)
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
            List<int> numbers = Enumerable.Range(1, sudokuToChange.size).ToList();

            Shuffle(numbers);

            foreach (int i in numbers)
            {
                if (IsValidInsert(row, col, i))
                {
                    sudokuToChange.sudokuTable[row, col] = i;
                    if (FillRemaining())
                    {
                        return true;
                    }
                    sudokuToChange.sudokuTable[row, col] = 0;
                }
            }
            return false;
        }

        public bool ValidateSudoku()
        {
            int sudokuLength = sudokuToChange.sudokuTable.GetLength(0);

            for (int cell_i = 0; cell_i < sudokuLength; cell_i++)
            {
                int row = cell_i;

                for (int cell_j = 0; cell_j < sudokuLength; cell_j++)
                {
                    int col = cell_j;

                    int value = sudokuToChange.sudokuTable[cell_i, cell_j];
                    
                    if(value == 0)
                    {
                        //Console.WriteLine("1");
                        return false;
                    }

                    for (int i = 0; i < sudokuLength; i++)
                    {
                        if (sudokuToChange.sudokuTable[row, i] == value && row != cell_i && i!=cell_j || sudokuToChange.sudokuTable[i, col] == value && i != cell_i && col != cell_j)
                        {
                            //Console.WriteLine($"2, {cell_i}, {cell_j}");
                            return false;
                        }
                    }

                    int startRow = row / sudokuToChange.blockSize * sudokuToChange.blockSize;
                    int startCol = col / sudokuToChange.blockSize * sudokuToChange.blockSize;

                    for (int i = startRow; i < startRow + sudokuToChange.blockSize; i++)
                    {
                        for (int j = startCol; j < startCol + sudokuToChange.blockSize; j++)
                        {
                            if (sudokuToChange.sudokuTable[i, j] == value && i!= cell_i && j!=cell_j)
                            {
                                //Console.WriteLine("3");
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }

        public int GetSudokuNumber(int row, int col)
        {
            return sudokuToChange.sudokuTable[row, col];
        }
        public void setSudokuNumber(int row, int col, int value)
        {
            sudokuToChange.sudokuTable[row,col] = value;
        }

    
    }
}
