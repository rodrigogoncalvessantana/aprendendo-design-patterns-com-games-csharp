using System;

namespace Adapter
{
    public class Personagem : IAcao
    {        
        public void Atirar()
        {
            Console.WriteLine("Atirou no jogo!");
        }

        public void Andar(string personagem)
        {
            Console.WriteLine(personagem + " ANDOU PARA FRENTE!");
        }
    }
}
