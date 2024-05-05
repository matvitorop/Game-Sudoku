using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public interface IVisitor
    {
        public void FillAndPrep(SudokuSmall visitor);
        public void FillAndPrep(SudokuMedium visitor);
        public void FillAndPrep(SudokuBig visitor);
        
    }
}
