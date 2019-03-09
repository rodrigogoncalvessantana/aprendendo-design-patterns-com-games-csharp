namespace Decorator
{
    public class ArmaduraPadrao : MoldeArmadura
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
