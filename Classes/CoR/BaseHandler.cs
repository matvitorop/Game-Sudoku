using Classes.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Classes.CoR
{
    public abstract class BaseHandler : IHandler
    {
        protected IHandler? NextHandler;

        public void SetNextHandler(IHandler handler)
        {
            NextHandler = handler;
        }

        public virtual ISudokuFactory HandleRequest(string question)
        {
            if (NextHandler != null)
            {
                return NextHandler.HandleRequest(question);
            }
            else
            {
                return null;
            }

        }
    }
}
