using Classes.Factory;

namespace Classes.CoR
{
    public class ReturnNormalFactory : BaseHandler
    {
        public override ISudokuFactory? HandleRequest(Difficult difficult)
        {
            return difficult.Equals(Difficult.Normal) ? 
                new NormalFactory() : base.HandleRequest(difficult);
        }
    }
}
