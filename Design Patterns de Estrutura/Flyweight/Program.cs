using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
//            Console.WriteLine("--------### Design Patterns Flyweight By Prof. Rodrigo Gonçalves ###--------");

            Flyweight flyweight = new Flyweight(); 
            string cor = string.Empty;

            Tartaruga tartaruga;

            while (true)
            {        
                Console.WriteLine();

                Console.Write("Qual tartaruga enviar para tela: ");
                //Extrínseco
                cor = Console.ReadLine(); 
                
                tartaruga = flyweight.GetTartaruga(cor);
                tartaruga.Mostra(cor);

                Console.WriteLine();
                Console.WriteLine("------------------------");
            }            
        }
    }
}
