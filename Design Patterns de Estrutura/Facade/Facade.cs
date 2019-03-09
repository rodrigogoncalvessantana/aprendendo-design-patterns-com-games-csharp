using System;

//Facade é a base de Centro de Comando
namespace Facade
{
    public class Facade
    {
        private SubSistemaUm um;
        private SubSistemaDois dois;
        private SubSistemaTres tres;

        public Facade()
        {
            this.um = new SubSistemaUm();
            this.dois = new SubSistemaDois();
            this.tres = new SubSistemaTres();
        }

        public void OperacaoA()
        {
            Console.WriteLine("\nOperação A ------- ");
            this.um.Responsabilidade();
            this.dois.Responsabilidade();            
        }

        public void OperacaoB()
        {
            Console.WriteLine("\nOperação B ------- ");           
            this.tres.Responsabilidade();
        }
    }
}
