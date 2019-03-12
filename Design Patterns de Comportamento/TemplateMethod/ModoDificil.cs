using System;

namespace TemplateMethod 
{
    public class ModoDificil : Jogo
    {
        public override void PrimeiraFase()
        {
            Console.WriteLine("Adicionar obstáculo na pista");
        }

        public override void SegundaFase()
        {
            Console.WriteLine("Carros adversário devem correr mais");

        }
    }
}
