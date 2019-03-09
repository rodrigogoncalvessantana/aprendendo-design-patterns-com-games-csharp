using System;

namespace Decorator
{
    public class Escudo : ItemArmadura
    {
        public override void Exibe()
        {
            Console.WriteLine("Equipado com: " + this.Descricao);
        }
    }
}
