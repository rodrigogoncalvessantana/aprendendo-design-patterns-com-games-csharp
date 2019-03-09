namespace Decorator
{
    public abstract class ArmaduraPersonagem
    {        
        private string _descricao = "Armadura do Personagem Abstrata";
       
        public virtual string Descricao
        {
            get { return _descricao; }
        }
    }    
}
