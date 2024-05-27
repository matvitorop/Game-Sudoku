using Classes.Factory;

namespace Classes.CoR
{
    public class ReturnHardFactory : BaseHandler
    {
        public override ISudokuFactory? HandleRequest(Difficult difficult)
        {
            return difficult.Equals(Difficult.Hard) ? 
                new HardFactory() : base.HandleRequest(difficult);
        }
    }
}
