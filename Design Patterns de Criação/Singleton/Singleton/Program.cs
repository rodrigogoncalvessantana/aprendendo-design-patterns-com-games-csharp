using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton jogador_1 = Singleton.GetInstancia;
            jogador_1.Mensagem("Jogador 1: A bola está comigo no meio do campo.");

            Singleton jogador_2 = Singleton.GetInstancia;
            jogador_2.Mensagem("Jogador 2: recebeu a bola.");

            Singleton jogador_3 = Singleton.GetInstancia;
            jogador_3.Mensagem("Jogador 3: recebeu o lançamento na linha de fundo.");

            Console.ReadKey();
        }
    }
}
