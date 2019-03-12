namespace Interpreter
{
    public class ArcoFlecha : IArmamento
    {
        public void Interpretar(Contexto contexto)
        {
            contexto.Output += string.Format(" {0} ", " Arco e Flecha ");
        }
    }
}
