namespace Interpreter
{
    public class Binoculos : IFerramenta
    {
        public void Interpretar(Contexto contexto)
        {
            contexto.Output += string.Format(" {0} ", " Binóculos ");
        }
    }
}
