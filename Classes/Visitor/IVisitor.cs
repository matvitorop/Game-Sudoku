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
        public void SudokuPrep(SudokuSmall visitor);
        public void SudokuPrep(SudokuMedium visitor);
        public void SudokuPrep(SudokuBig visitor);

    }
}
