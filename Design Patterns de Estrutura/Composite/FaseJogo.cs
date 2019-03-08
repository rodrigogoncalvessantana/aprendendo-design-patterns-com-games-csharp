using System;

namespace Composite
{
    public class FaseJogo : ComponenteFase
    {
        public FaseJogo(string nome) : base(nome)
        {

        }

        public override void Adicionar(ComponenteFase c)
        {
            Console.WriteLine("Não é possível adicionar a fase no jogo!");
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new string('-', profundidade) + nome);
        }

        public override void Remover(ComponenteFase c)
        {
            Console.WriteLine("Não é possível remover a fase do jogo!");
        }
    }
}
