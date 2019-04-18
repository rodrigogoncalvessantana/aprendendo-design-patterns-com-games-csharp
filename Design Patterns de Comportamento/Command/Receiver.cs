using System;

namespace Command
{
    public class Receiver
    {
        public void PrimeiroPedido(string a)
        {
            Console.WriteLine("Comando Recebido: " + a);
        }

        public void SegundoPedido(string b)
        {
            Console.WriteLine("Outro Comando Recebido: " + b);
        }
    }
}
