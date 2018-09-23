namespace MiddlewareAvancado.Repository
{
    public interface ITeste
    {
        string teste();
    }
    public class Teste : ITeste
    {
        public string teste(){
            return "teste 1";
        }
    }
}