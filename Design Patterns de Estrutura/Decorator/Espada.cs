namespace Decorator
{
    public class Espada : DecoratorArmadura
    {        
        string _descricao = "Espada Ultra Forte, ";
        MoldeArmadura _moldeArmadura;

        public Espada(MoldeArmadura moldeArmadura)
        {
            _moldeArmadura = moldeArmadura;
        }
     
        public override string Descricao
        {
            get
            {
                return _moldeArmadura.Descricao + _descricao;
            }
        }
    }
}
