using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Controle controle = new Controle();
            controle.EnviarComandoSimples(new SimplesComando("Dizer Oi!"));

            Receiver receiver = new Receiver();
            controle.EnviarComandoComplexo(new ComplexoComando(receiver, "Abastecer o carro", "Calibrar os pneus do carro"));

            controle.Fazer();
            Console.ReadKey();
        }
    }
}
