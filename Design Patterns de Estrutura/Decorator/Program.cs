using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemArmadura espada = new Espada();
            espada.Descricao = "Espada Ultra Forte";

            ItemArmadura escudo = new Escudo();
            escudo.Descricao = "Escudo de Titanium";

            ItemArmadura capacete = new Capacete();
            capacete.Descricao = "Capacete a prova de balas";

            Console.WriteLine("Seu personagem está equipado com: ");
            EquiparPersonagem usar_espada = new EquiparPersonagem(espada);
            EquiparPersonagem usar_escudo = new EquiparPersonagem(escudo);
            EquiparPersonagem usar_capacete = new EquiparPersonagem(capacete);

            Console.ReadKey();
        }
    }
}
