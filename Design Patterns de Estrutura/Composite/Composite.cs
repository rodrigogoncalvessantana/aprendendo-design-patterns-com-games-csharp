using System;
using System.Collections.Generic;

namespace Composite
{
    public class Composite : ComponenteFase
    {

        private List<ComponenteFase> fasesjogo = new List<ComponenteFase>();

        public Composite(string nome): base(nome)
        {
            
        }

        public override void Adicionar(ComponenteFase c)
        {
            this.fasesjogo.Add(c);
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new string('-', profundidade) + nome); 

            foreach (ComponenteFase item in this.fasesjogo)
            {
                item.Mostrar(profundidade + 2);
            }
        }

        public override void Remover(ComponenteFase c)
        {
            this.fasesjogo.Remove(c);
        }
    }
}
