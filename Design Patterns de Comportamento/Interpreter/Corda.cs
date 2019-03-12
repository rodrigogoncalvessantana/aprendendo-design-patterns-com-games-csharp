namespace Interpreter
{
    public class Corda : IFerramenta
    {
        public void Interpretar(Contexto contexto)
        {
            contexto.Conteudo += string.Format(" {0} ", " Corda ");
        }
    }
}
