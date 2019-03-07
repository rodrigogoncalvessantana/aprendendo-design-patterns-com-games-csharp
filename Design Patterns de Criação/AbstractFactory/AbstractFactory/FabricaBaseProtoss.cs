using System;

namespace AbstractFactory
{
    public class FabricaBaseProtoss : IFabricaBases
    {
        public FabricaBaseProtoss()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            Console.WriteLine("Base Protoss criada com sucesso!");

            RevestimentoBaseProtoss revestimento = new RevestimentoBaseProtoss();
            revestimento.Composicao();

            EnergiaBaseProtoss energia = new EnergiaBaseProtoss();
            energia.Composicao();
        }
    }
}
