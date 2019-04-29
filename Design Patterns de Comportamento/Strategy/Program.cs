using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var papagaio = new Ajuda(new Papagaio());
            Console.WriteLine(papagaio.Ajudar());

            var sapo = new Ajuda(new Sapo());
            Console.WriteLine(sapo.Ajudar());

            Console.ReadKey();
        }
    }
}