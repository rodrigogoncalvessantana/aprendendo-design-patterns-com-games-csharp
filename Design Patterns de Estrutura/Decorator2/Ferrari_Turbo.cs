namespace Decorator2
{
    public class Ferrari_Turbo : DecoratorCarro
    {
        double _preco = 9500.50;
        string _descricao = "Turbo, ";
        Carro _carro;

        public Ferrari_Turbo(Carro carro)
        {
            _carro = carro;
        }

        public override double Preco
        {
            get
            {
                return _carro.Preco + _preco;
            }
        }

        public override string Descricao
        {
            get
            {
                return _carro.Descricao + _descricao;
            }
        }
    }
}
