namespace Mediator
{
    public abstract class Jogador
    {
        protected Mediador mediador;

        public Jogador(Mediador mediador)
        {
            this.mediador = mediador; 
        }
    }
}
