using System;

namespace Decorator2
{
    class Program
    {
        static void Main(string[] args)
        {

            //criar um carro
            Console.WriteLine(" --------------Ferrari Padrão-----------------------");
            Carro carro = new FerrariSpider();
            Console.WriteLine("Descricao --> " + carro.Descricao.TrimEnd(' ', ','));
            Console.WriteLine("Preco -->" + carro.Preco.ToString());
            Console.ReadLine();

            Console.WriteLine(" --------------Ferrari Decorada---------------------");
            //decora o carro com banco de couro
            carro = new Ferrari_Couro(carro);
            //decora o carro com motor turbo
            carro = new Ferrari_Turbo(carro);
            Console.WriteLine("Descricao --> " + carro.Descricao.TrimEnd(' ', ','));
            Console.WriteLine("Preco -->" + carro.Preco.ToString());
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
