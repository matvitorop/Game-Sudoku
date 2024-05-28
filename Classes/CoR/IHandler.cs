using Classes.Factory;

namespace Classes.CoR
{
    public interface IHandler
    {
        public ISudokuFactory? HandleRequest(Difficult difficult);
    }
}
