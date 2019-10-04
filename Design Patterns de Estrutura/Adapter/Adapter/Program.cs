using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem rodrigo = new Personagem();
            Aviao aviao_de_batalha = new Aviao();

            IAcao adaptador = new Adapter(aviao_de_batalha);
            
            Console.WriteLine("--- CAMINHANDO ---");
            rodrigo.Andar("Rodrigo");
            rodrigo.Atirar();

            Console.WriteLine();

            Console.WriteLine("--- PEGOU UM AVIÃO NO JOGO ---");
            adaptador.Andar("Rodrigo");
            adaptador.Atirar();

            Console.ReadKey();
        }
    }
}
