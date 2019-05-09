using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Acao acao = new Acao();
            acao.Estado = "Play";

            Armazena armazena = new Armazena();
            armazena.Memento = acao.CriarMemento();

            acao.Estado = "Pause";
            acao.RestaurarEstado(armazena.Memento);

            Console.ReadKey();
        }
    }
}
