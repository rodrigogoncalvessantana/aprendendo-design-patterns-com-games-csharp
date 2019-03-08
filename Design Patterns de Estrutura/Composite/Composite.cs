using System;
using System.Collections.Generic;

namespace Composite
{
    public class Composite : ComponenteFase
    {

        private List<ComponenteFase> filhos = new List<ComponenteFase>();

        public Composite(string nome): base(nome)
        {
            
        }

        public override void Adicionar(ComponenteFase c)
        {
            this.filhos.Add(c);
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new string('-', profundidade) + nome); 

            foreach (ComponenteFase item in this.filhos)
            {
                item.Mostrar(profundidade + 2);
            }
        }

        public override void Remover(ComponenteFase c)
        {
            this.filhos.Remove(c);
        }
    }
}
