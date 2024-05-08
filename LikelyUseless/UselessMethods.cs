using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikelyUseless
{
    public class UselessMethods
    {
        public bool ValidateSudoku()
        {
            //int size = sudokuToChange.sudokuTable.GetLength(0); // Отримуємо розмір судоку (кількість рядків або стовпців)
            //
            //// Перевірка, чи є квадратна матриця (чи кількість рядків дорівнює кількості стовпців)
            //if (sudokuToChange.sudokuTable.GetLength(0) != sudokuToChange.sudokuTable.GetLength(1))
            //{
            //    return false; // Якщо не є квадратною, судоку неправильне
            //}
            //
            //// Перевірка чи правильно заповнені числа у межах допустимих значень
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        if (sudokuToChange.sudokuTable[i, j] <= 0 || sudokuToChange.sudokuTable[i, j] > size)
            //        {
            //            return false; // Якщо число поза межами допустимих значень, судоку неправильне
            //        }
            //    }
            //}
            //
            //// Перевірка унікальності чисел у кожному рядку
            //for (int i = 0; i < size; i++)
            //{
            //    bool[] seen = new bool[size + 1]; // Масив для відстеження вже побачених чисел
            //    for (int j = 0; j < size; j++)
            //    {
            //        int num = sudokuToChange.sudokuTable[i, j];
            //        if (seen[num])
            //        {
            //            return false; // Якщо число вже було побачено, судоку неправильне
            //        }
            //        seen[num] = true;
            //    }
            //}
            //
            //// Перевірка унікальності чисел у кожному стовпці
            //for (int j = 0; j < size; j++)
            //{
            //    bool[] seen = new bool[size + 1]; // Масив для відстеження вже побачених чисел
            //    for (int i = 0; i < size; i++)
            //    {
            //        int num = sudokuToChange.sudokuTable[i, j];
            //        if (seen[num])
            //        {
            //            return false; // Якщо число вже було побачено, судоку неправильне
            //        }
            //        seen[num] = true;
            //    }
            //}
            //
            //// Перевірка унікальності чисел у кожному квадраті
            //int sqrtSize = (int)Math.Sqrt(size);
            //for (int blockRow = 0; blockRow < sqrtSize; blockRow++)
            //{
            //    for (int blockCol = 0; blockCol < sqrtSize; blockCol++)
            //    {
            //        bool[] seen = new bool[size + 1]; // Масив для відстеження вже побачених чисел
            //        for (int i = blockRow * sqrtSize; i < (blockRow + 1) * sqrtSize; i++)
            //        {
            //            for (int j = blockCol * sqrtSize; j < (blockCol + 1) * sqrtSize; j++)
            //            {
            //                int num = sudokuToChange.sudokuTable[i, j];
            //                if (seen[num])
            //                {
            //                    return false; // Якщо число вже було побачено, судоку неправильне
            //                }
            //                seen[num] = true;
            //            }
            //        }
            //    }
            //}
            //
            //return true; // Якщо всі перевірки пройдені успішно, судоку правильне

            // ================ SUDOKU GENERATOR ================

            //Random random = new Random();
            //
            //int[,] sudoku = new int[9,9]; 
            //
            //bool IsValidInsert(int[,] sudoku, int row, int col, int num)
            //{
            //    for (int i = 0; i<9; i++)
            //    {
            //        if (sudoku[row, i] == num || sudoku[i,col] == num)
            //        {
            //            return false;
            //        }
            //    }
            //
            //    int startRow = row / 3 * 3;
            //    int startCol = col / 3 * 3;
            //
            //    for(int i = startRow; i<startRow+3; i++)
            //    {
            //        for (int j = startCol; i < startCol + 3; i++)
            //        {
            //            if (sudoku[startRow, startCol] == num)
            //            {
            //                return false ;
            //            }
            //        }
            //    }
            //
            //    return true;
            //}
            //
            //void FillFirstRow(int[,] sudoku)
            //{
            //    List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9 };
            //    Shuffle(numbers);
            //    
            //    for (int i = 0; i < 9; i++)
            //    {
            //        sudoku[0, i] = numbers[i];
            //    }
            //
            //}
            //
            //void Shuffle<T>(List<T> list)
            //{
            //    int n = list.Count; 
            //    while (n > 1)
            //    {
            //        n--;
            //        int k = random.Next(n+1);
            //        T value = list[k];
            //        list[k] = list[n];
            //        list[n] = value;
            //    }
            //}
            //bool FillRemaining(int[,] sudoku)
            //{
            //    int row = -1;
            //    int col = -0;
            //    bool isEmpty = true;
            //
            //    for(int i = 0; i<9; i++)
            //    {
            //        for (int j = 0; j < 9; j++)
            //        {
            //            if (sudoku[i, j] == 0)
            //            {
            //                isEmpty = false;
            //                row = i;
            //                col = j;
            //                break;
            //            }
            //        }
            //        if (!isEmpty)
            //        {
            //            break;
            //        }
            //    }
            //
            //    if (isEmpty)
            //    {
            //        return true;
            //    }
            //    List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //
            //    Shuffle(numbers);
            //
            //    foreach (int i in numbers)
            //    {
            //        if(IsValidInsert(sudoku, row, col, i))
            //        {
            //            sudoku[row, col] = i;
            //            if (FillRemaining(sudoku))
            //            {
            //                return true ;
            //            }
            //            sudoku[row, col] = 0;
            //        }
            //    }
            //    return false;
            //}
            //
            //
            //int[,] GenerateSudoku()
            //{
            //    int[,] sudoku = new int[9, 9];
            //
            //    FillFirstRow(sudoku);
            //    FillRemaining(sudoku);
            //
            //    return sudoku;
            //}
            //
            //int[,] sudokuBoard = GenerateSudoku();


            //for (int i = 0; i < 9; i++)
            //{
            //    for (int j = 0; j < 9; j++)
            //    {
            //        Console.Write(sudokuBoard[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //Sudoku big = new SudokuBig(10);
            //Sudoku sm = new SudokuSmall(10);
            //Sudoku med = new SudokuMedium(10);
            //med.GenerateSudoku();
            //big.GenerateSudoku();
            //sm.GenerateSudoku();

            //for (int i = 0; i < 16; i++)
            //{
            //    for (int j = 0; j < 16; j++)
            //    {
            //        Console.Write(big.sudokuTable[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            return true;

        }
    }
}
