using Classes.SudokuTypes;

namespace Classes.Memento
{
    public class SudokuCaretaker(Sudoku sudoku)
    {
        private readonly List<ISnapshot> _mementos = [];

        public void SaveBackup()
        {
            _mementos.Add(sudoku.Save());
        }

        public bool Restore()
        {
            if (_mementos.Count != 0)
            {
                var snapshot = _mementos.Last();
                sudoku.Restore(snapshot);
                _mementos.Remove(snapshot);
                return true;
            }

            return false;
        }
    }
}
