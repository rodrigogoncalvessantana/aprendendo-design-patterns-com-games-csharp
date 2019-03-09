namespace Decorator
{
    public class Capacete : DecoratorArmadura
    {        
        string _descricao = "Capacte, ";
        ArmaduraPersonagem _armadurapersonagem;

        public Capacete(ArmaduraPersonagem armadurapersonagem)
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
