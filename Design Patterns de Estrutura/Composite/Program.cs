using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite mapa = new Composite("MAPA DAS CAVERNAS");

            Composite cano1 = new Composite("Caverna 1");
            cano1.Adicionar(new FaseJogo("Sub Fase 1"));
            cano1.Adicionar(new FaseJogo("Sub Fase 2"));
            cano1.Adicionar(new FaseJogo("Sub Fase 3"));

            Composite cano2 = new Composite("Caverna 2");
            cano2.Adicionar(new FaseJogo("Sub Fase 4"));
            cano2.Adicionar(new FaseJogo("Sub Fase 5"));

            Composite porta_secreta = new Composite("Porta Secreta");
            porta_secreta.Adicionar(new FaseJogo("Sub Fase Secreta X"));

            mapa.Adicionar(cano1);
            mapa.Adicionar(cano2);
            cano2.Adicionar(porta_secreta);

            //root.Adicionar(folha);
            //root.Remover(folha);

            mapa.Mostrar(1);

            Console.ReadKey();

        }
    }
}
