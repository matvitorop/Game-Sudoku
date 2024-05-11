using Classes.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.CoRAddingScore
{
    public interface IScoreHandler
    {
        public ISudokuFactory HandleRequest(string question);
    }
}
