using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            MediadorConcreto mediador = new MediadorConcreto();

            Jogador1 j1 = new Jogador1(mediador);
            Jogador2 j2 = new Jogador2(mediador);

            mediador.Jogador1 = j1;
            mediador.Jogador2 = j2;

            j1.Enviar("Essa partida foi muito boa!");
            j2.Enviar("Foi sensacional. Conseguimos uma ótima pontuação!");

            Console.ReadKey();
        }
    }
}
