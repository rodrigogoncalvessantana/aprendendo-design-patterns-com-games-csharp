namespace Decorator
{
    public class ArmaduraPadrao : ArmaduraPersonagem
    {        
        string _descricao = "Proteção Simples, ";
        
        public override string Descricao
        {
            get
            {
                return _descricao;
            }
        }
    }
}
