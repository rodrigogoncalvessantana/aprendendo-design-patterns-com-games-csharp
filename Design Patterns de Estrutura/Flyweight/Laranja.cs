using System;

namespace Flyweight
{
    //Nossa classe concreta, aquela que estamos implementando.
    public class Laranja : Tartaruga
    {
        public Laranja()
        {
            this.condicao = "tartaruga dentro do casco, ";
            this.acao = "rodando no chão - ";
        }

        public override void Mostra(string qualcor)
        {
            this.cor = qualcor;
            Console.WriteLine(condicao + acao + cor.ToUpper());
        }
    }
}
