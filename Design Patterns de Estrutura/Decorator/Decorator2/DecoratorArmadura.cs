namespace Decorator
{
    public class DecoratorArmadura : ArmaduraPersonagem
    {        
        string _descricao = "Decorador Abstrato da Armadura do Persoangem";
       
        public override string Descricao
        {
            get { return _descricao; }
        }
    }
}
