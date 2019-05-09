using System;

namespace State
{
    public class Contexto
    {
        private State _estado;

        public Contexto(State estado)
        {
            this._estado = estado;
        }

        public State State
        {
            get { return _estado; }
            set
            {
                _estado = value;
                Console.WriteLine("Agora o comportamento é de: " + _estado.GetType().Name);
            }
        }

        public void Troca()
        {
            _estado.Acao(this);
        }
    }
}
