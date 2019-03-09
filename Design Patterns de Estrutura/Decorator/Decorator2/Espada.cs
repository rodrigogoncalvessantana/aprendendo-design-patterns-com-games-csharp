namespace Decorator
{
    public class Espada : DecoratorArmadura
    {        
        string _descricao = "Espada Ultra Forte, ";
        ArmaduraPersonagem _armadurapersonagem;

        public Espada(ArmaduraPersonagem armadurapersonagem)
        {
            _armadurapersonagem = armadurapersonagem;
        }
     
        public override string Descricao
        {
            get
            {
                return _armadurapersonagem.Descricao + _descricao;
            }
        }
    }
}
