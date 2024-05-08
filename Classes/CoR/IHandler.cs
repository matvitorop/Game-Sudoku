using Classes.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.CoR
{
    public interface IHandler
    {
        public ISudokuFactory HandleRequest(string question);
    }
}
