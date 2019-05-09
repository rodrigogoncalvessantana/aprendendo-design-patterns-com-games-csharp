using System;

namespace Mediator
{
    public class Jogador2 : Jogador
    {
        public Jogador2(Mediador mediador) : base(mediador) {}

        public void Enviar(string mensagem)
        {
            mediador.Enviar(mensagem, this);
        }

        public void Notificar(string mensagem)
        {
            Console.WriteLine("Mensagem do Jogador 2: " + mensagem);
        }
    }
}
