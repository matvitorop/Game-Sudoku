using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.SudokuTypes;

namespace Classes.Visitor
{
    public interface IVisitor
    {
        void SudokuPrep<T>(T visitor) where T : Sudoku;
    }

}
