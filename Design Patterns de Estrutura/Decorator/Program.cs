using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine(" ### Veste Armadura Padrão ###");
            MoldeArmadura armadura = new ArmaduraPadrao();
            Console.WriteLine("Descrição: " + armadura.Descricao.TrimEnd(' ', ','));

            Console.WriteLine();

            Console.WriteLine(" ### Incluir Novos Itens na Armadura (Decorar) ###");
            armadura = new Capacete(armadura);
            armadura = new Espada(armadura);

            Console.WriteLine("Descrição: " + armadura.Descricao.TrimEnd(' ', ','));

            Console.ReadKey();
        }
    }
}
