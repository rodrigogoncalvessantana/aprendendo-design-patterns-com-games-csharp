using System;

namespace Memento
{
    public class Acao
    {
        private string _estado;

        public string Estado
        {
            get { return _estado; }
            set
            {
                _estado = value;
                Console.WriteLine("Estado do Jogo = " + _estado);
            }
        }

        public Memento CriarMemento()
        {
            return (new Memento(_estado));
        }

        public void RestaurarEstado(Memento memento)
        {
            Console.WriteLine("Restaurando o estado...");
            Estado = memento.Estado;
        }
    }
}
