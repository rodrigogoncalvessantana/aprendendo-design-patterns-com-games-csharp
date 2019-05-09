namespace Mediator
{
    public class MediadorConcreto : Mediador
    {
        private Jogador1 j1;
        private Jogador2 j2;

        public Jogador1 Jogador1
        {
            set { j1 = value; }
        }

        public Jogador2 Jogador2
        {
            set { j2 = value; }
        }

        public override void Enviar(string mensagem, Jogador jogador)
        {
            if (jogador == j2)
                j1.Notificar(mensagem);
            else
                j2.Notificar(mensagem); 
        }
    }
}
