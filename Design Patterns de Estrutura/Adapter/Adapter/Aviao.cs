using System;

namespace Adapter
{
    public class Aviao
    {        
        public void Voar(string personagem)
        {            
            Console.WriteLine(personagem + " VOOU PARA FRENTE!");
        }
        
        public void SoltarMissil()
        {          
            Console.WriteLine("Soltou um míssil no jogo!");
        }
    }
}
