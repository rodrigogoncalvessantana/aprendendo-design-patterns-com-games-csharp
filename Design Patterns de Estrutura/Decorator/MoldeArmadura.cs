namespace Decorator
{
    public abstract class MoldeArmadura
    {        
        private string _descricao = "Armadura do Personagem Abstrata";
       
        public virtual string Descricao
        {
            get { return _descricao; }
        }
    }    
}
