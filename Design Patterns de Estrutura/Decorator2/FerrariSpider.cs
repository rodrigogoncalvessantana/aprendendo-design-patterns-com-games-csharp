namespace Decorator2
{
    public class FerrariSpider : Carro
    {
        double _preco = 255000.99;
        string _descricao = "Ferrari Spider, ";

        public override double Preco
        {
            get
            {
                return _preco;
            }
        }
        public override string Descricao
        {
            get
            {
                return _descricao;
            }
        }
    }
}
