using Classes.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.CoR
{
    public class ReturnNormalFactory : BaseHandler
    {
        public override ISudokuFactory HandleRequest(string question)
        {
            if (question.Equals("normal"))
            {
                return new NormalFactory();
            }
            else
            {
                return base.HandleRequest(question);
            }
        }
    }
}
