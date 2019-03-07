using System;

namespace AbstractFactory
{
    public class EnergiaBaseTerran : IEnergia
    {
        public void Composicao()
        {
            Console.WriteLine("Energia de sustentação da base mecânica");
        }
    }
}
