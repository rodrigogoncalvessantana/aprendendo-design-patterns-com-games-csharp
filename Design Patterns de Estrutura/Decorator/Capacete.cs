using System;

namespace Decorator
{
    public class Capacete : ItemArmadura
    {
        public override void Exibe()
        {
            Console.WriteLine("Equipado com: " + this.Descricao);
        }
    }
}
