using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod fm = new FactoryMethod();

            
            Console.WriteLine("Liu Kang | SubZero | Scorpion");
            Console.WriteLine();

            Console.Write("Escolha seu Personagem: ");
            string escolha = Console.ReadLine();

            IPersonagem personagem = fm.Escolher_Personagem(escolha);
            Console.WriteLine();
            Console.Write("Você vai jogar com ");
            personagem.Escolhido();


            Console.ReadKey();
        }
    }
}
