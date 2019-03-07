using System;

namespace AbstractFactory
{
    public class RevestimentoBaseProtoss : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Base revestida pela cor amarela");
        }
    }
}
