using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#### Acessando a Fase do Jogo sem o Proxy ####");
            FaseJogo usuario = new FaseJogo();
            Console.WriteLine(usuario.Consultar());
            Console.WriteLine();
            
            Console.WriteLine("----- Usando o Proxy para controlar o acesso a fase do jogo -----");            
            Console.WriteLine();
            
            ProxyUsuario proxy;
            proxy = new ProxyUsuario();

            //
            Console.WriteLine("#### Tentando acessar a fase do jogo sem informar o Password ####");
            Console.WriteLine(proxy.Consultar());

            Console.WriteLine();
            
            Console.WriteLine("#### Tentando acessar a fase do jogo com Password incorreto ####");
            Console.WriteLine(proxy.InformarPassword("465"));
            Console.WriteLine(proxy.Consultar());

            Console.WriteLine();

            Console.WriteLine("#### Tentando acessar a fase do jogo com Password correto ####");
            Console.WriteLine(proxy.InformarPassword("123"));
            Console.WriteLine(proxy.Consultar());
            Console.WriteLine();
            
            Console.ReadKey();
        }
    }
}
