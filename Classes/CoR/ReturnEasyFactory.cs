using Classes.Factory;

namespace Classes.CoR
{
    public class ReturnEasyFactory : BaseHandler
    {
        public override ISudokuFactory? HandleRequest(Difficult difficult)
        {
            return difficult.Equals(Difficult.Easy) ? 
                new EasyFactory() : base.HandleRequest(difficult);
        }
    }
}
