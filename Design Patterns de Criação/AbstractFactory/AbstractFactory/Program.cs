using System;


namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFabricaBases fabrica;
            Console.Write("Escolha um dos personagens: 1-Protoss | 2-Zergs | 3-Terranos: ");           

            switch (Console.ReadLine())
            {
                case "1":
                    fabrica = new FabricaBaseProtoss();
                    break;
                case "2":
                    fabrica = new FabricaBaseZerg();
                    break;
                case "3":
                    fabrica = new FabricaBaseTerran();
                    break;
            }            

            Console.ReadLine();            
        }
    }
}
