using System;

namespace Decorator
{
    public class Espada : ItemArmadura
    {
        public override void Exibe()
        {
            Console.WriteLine("Equipado com: " + this.Descricao);
        }
    }
}
