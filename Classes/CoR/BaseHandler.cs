using Classes.Factory;

namespace Classes.CoR
{
    public abstract class BaseHandler : IHandler
    {
        private IHandler? _nextHandler;

        public void SetNextHandler(IHandler handler)
        {
            _nextHandler = handler;
        }

        public virtual ISudokuFactory? HandleRequest(Difficult difficult)
        {
            return _nextHandler?.HandleRequest(difficult);
        }
    }
    
    public enum Difficult
    {
        Easy,
        Normal,
        Hard
    }
}
