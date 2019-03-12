using System;

namespace TemplateMethod
{
    public abstract class Jogo
    {
        public Jogo()
        {
            TrilhaSonora();
            PrimeiraFase();
            SegundaFase();
        }

        public abstract void PrimeiraFase();
        public abstract void SegundaFase();

        private void TrilhaSonora()
        {
            Console.WriteLine("Música emocionante"); 
        }
    }
}
