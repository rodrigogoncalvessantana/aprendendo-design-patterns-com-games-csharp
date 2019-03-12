using System;
using System.Collections.Generic;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IJogo> jogo = new List<IJogo>();            
            jogo.Add(new FaseJogo() { NomeFase = "Floresta"});
            jogo.Add(new FaseJogo() { NomeFase = "Caverna" });
            jogo.Add(new Chefao() { NomeChefao = "Boss 1", PontosVida = 30 });
            jogo.Add(new Chefao() { NomeChefao = "Boss 2", PontosVida = 50 });

            NivelVisitor niveis = new NivelVisitor();
            foreach (var etapa in jogo)
            {
                etapa.Visitante(niveis);
            }

            Console.ReadLine();
        }
    }
}
