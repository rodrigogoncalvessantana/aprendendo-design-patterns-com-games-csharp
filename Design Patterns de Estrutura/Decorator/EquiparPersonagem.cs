using System;
using System.Collections.Generic;

namespace Decorator
{
    public class EquiparPersonagem : Decorator
    {
        //protected List<string> equipamentos = new List<string>();

        public EquiparPersonagem(ItemArmadura item) : base(item)
        {
            Console.WriteLine(" Equipado com: " + item.Descricao);
        }               
    }
}
