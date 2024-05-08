using Classes.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.CoR
{
    public class ReturnEasyFactory : BaseHandler
    {
        public override ISudokuFactory HandleRequest(string question)
        {
            if (question.Equals("easy"))
            {
                return new EasyFactory();
            }
            else
            {
                return base.HandleRequest(question);
            }
        }
    }
}
