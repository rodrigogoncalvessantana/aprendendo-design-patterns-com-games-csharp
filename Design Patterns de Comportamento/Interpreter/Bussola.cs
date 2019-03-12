namespace Interpreter
{
    public class Bussola : IFerramenta
    {
        public void Interpretar(Contexto contexto)
        {
            contexto.Output += string.Format(" {0} ", " Bússola ");
        }
    }
}
