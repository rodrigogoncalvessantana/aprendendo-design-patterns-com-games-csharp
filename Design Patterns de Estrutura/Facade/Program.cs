using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.OperacaoA();
            facade.OperacaoB();

            Console.ReadKey();
        }
    }
}
