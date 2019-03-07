using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var exercito = new Exercito();
            CriadorDeSoldado criadorDeSoldado;
            Soldado soldado;

            // criando um soldado das Forças Especiais
            criadorDeSoldado = new CriadorForcasEspeciais();
            exercito.ConstruirSoldado(criadorDeSoldado);
            soldado = criadorDeSoldado.ObterSoldado();
            Console.WriteLine("Soldado com as características: {0}, {1}, {2}",
                    soldado.Arma, soldado.Transporte, soldado.Foco);

            // criando o soldado de Infantaria Leve 
            criadorDeSoldado = new CriadorDeInfantariaLeve();
            exercito.ConstruirSoldado(criadorDeSoldado);
            soldado = criadorDeSoldado.ObterSoldado();
            Console.WriteLine("Soldado com as características: {0}, {1}, {2}",
                    soldado.Arma, soldado.Transporte, soldado.Foco);

            Console.ReadKey();
        }
    }
}
