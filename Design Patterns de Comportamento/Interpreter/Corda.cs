namespace Interpreter
{
    public class Corda : IFerramenta
    {
        public void Interpretar(Contexto contexto)
        {
            contexto.Output += string.Format(" {0} ", " Corda ");
        }
    }
}
