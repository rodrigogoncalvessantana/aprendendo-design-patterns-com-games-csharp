namespace Decorator2
{
    public class Ferrari_Couro : DecoratorCarro
    {
        double _preco = 4250.25;
        string _descricao = "Banco de Couros, ";
        Carro _carro;

        public Ferrari_Couro(Carro carro)
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
