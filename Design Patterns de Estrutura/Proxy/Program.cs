using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#### Acessando a Fase do Jogo sem o Proxy ####");
            FaseJogo fase = new FaseJogo();
            Console.WriteLine(fase.Jogar());
            Console.WriteLine();
            
            Console.WriteLine("----- Usando o Proxy para controlar o acesso a fase do jogo -----");            
            Console.WriteLine();
            
            ProxyFase proxy = new ProxyFase();
            
            Console.WriteLine("#### Tentando acessar a fase do jogo sem informar o Password ####");
            Console.WriteLine(proxy.Jogar());

            Console.WriteLine();
            
            Console.WriteLine("#### Tentando acessar a fase do jogo com Password incorreto ####");
            Console.WriteLine(proxy.InformarPassword("465"));
            Console.WriteLine(proxy.Jogar());

            Console.WriteLine();

            Console.WriteLine("#### Tentando acessar a fase do jogo com Password correto ####");
            Console.WriteLine(proxy.InformarPassword("123"));
            Console.WriteLine(proxy.Jogar());
            Console.WriteLine();
            
            Console.ReadKey();
        }
    }
}
