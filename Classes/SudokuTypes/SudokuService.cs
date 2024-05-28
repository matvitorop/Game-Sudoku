namespace Classes.SudokuTypes;

public sealed class SudokuService
{
    private static SudokuService? _instance;
    private readonly Random _random = new();
    private Sudoku _sudokuToChange = null!;

    private SudokuService()
    {
        // Приватний конструктор для запобігання створенню екземплярів ззовні.
    }

    public static SudokuService? Instance
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
        _sudokuToChange = sudoku;
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

    private int CalculateStartIndex(int side)
    {
        return side / _sudokuToChange.BlockSize * _sudokuToChange.BlockSize; ;
    }

    private bool IsValidInsert(int row, int col, int num)
    {
        for (int i = 0; i < _sudokuToChange.SudokuTable.GetLength(0); i++)
        {
            if (_sudokuToChange.SudokuTable[row, i] == num || _sudokuToChange.SudokuTable[i, col] == num)
            {
                return false;
            }
        }

        int startRow = CalculateStartIndex(row);
        int startCol = CalculateStartIndex(col);

        for (int i = startRow; i < startRow + _sudokuToChange.BlockSize; i++)
        {
            for (int j = startCol; j < startCol + _sudokuToChange.BlockSize; j++)
            {
                if (_sudokuToChange.SudokuTable[i, j] == num)
                {
                    return false;
                }
            }
        }

        return true;
    }

    public void FillFirstRow()
    {
        _sudokuToChange.Size = _sudokuToChange.SudokuTable.GetLength(0);

        List<int> numbers = Enumerable.Range(1, _sudokuToChange.Size).ToList();
        Shuffle(numbers);

        for (int i = 0; i < _sudokuToChange.Size; i++)
        {
            _sudokuToChange.SudokuTable[0, i] = numbers[i];
        }
    }

    private void Shuffle<T>(List<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = _random.Next(n + 1);
            (list[k], list[n]) = (list[n], list[k]);
        }
    }

    private bool FillRemaining()
    {
        int row = -1;
        int col = -1;
        bool isEmpty = true;
        for (int i = 0; i < _sudokuToChange.Size; i++)
        {
            for (int j = 0; j < _sudokuToChange.Size; j++)
            {
                if (_sudokuToChange.SudokuTable[i, j] == 0)
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
        List<int> numbers = Enumerable.Range(1, _sudokuToChange.Size).ToList();

        Shuffle(numbers);

        foreach (int i in numbers)
        {
            if (IsValidInsert(row, col, i))
            {
                _sudokuToChange.SudokuTable[row, col] = i;
                if (FillRemaining())
                {
                    return true;
                }
                _sudokuToChange.SudokuTable[row, col] = 0;
            }
        }
        return false;
    }

    public bool ValidateSudoku()
    {
        int sudokuLength = _sudokuToChange.SudokuTable.GetLength(0);

        for (int cellI = 0; cellI < sudokuLength; cellI++)
        {
            int row = cellI;

            for (int cellJ = 0; cellJ < sudokuLength; cellJ++)
            {
                int col = cellJ;

                int value = _sudokuToChange.SudokuTable[cellI, cellJ];
                    
                if(value == 0)
                {
                    //Console.WriteLine("1");
                    return false;
                }

                for (int i = 0; i < sudokuLength; i++)
                {
                    if (_sudokuToChange.SudokuTable[row, i] == value && row != cellI && i!=cellJ || _sudokuToChange.SudokuTable[i, col] == value && i != cellI && col != cellJ)
                    {
                        //Console.WriteLine($"2, {cell_i}, {cell_j}");
                        return false;
                    }
                }

                int startRow = CalculateStartIndex(row);
                int startCol = CalculateStartIndex(col);

                for (int i = startRow; i < startRow + _sudokuToChange.BlockSize; i++)
                {
                    for (int j = startCol; j < startCol + _sudokuToChange.BlockSize; j++)
                    {
                        if (_sudokuToChange.SudokuTable[i, j] == value && i!= cellI && j!=cellJ)
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
        return _sudokuToChange.SudokuTable[row, col];
    }
    public void SetSudokuNumber(int row, int col, int value)
    {
        _sudokuToChange.SudokuTable[row,col] = value;
    }
}