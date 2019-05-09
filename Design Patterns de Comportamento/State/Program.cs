using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Contexto contexto = new Contexto(new PersonagemA());

            contexto.Troca();
            contexto.Troca();
            contexto.Troca();
            contexto.Troca();

            Console.ReadKey();
        }
    }
}
