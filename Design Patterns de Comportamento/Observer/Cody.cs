using System.Collections.Generic;

namespace Observer
{
    public class Cody : IPersonagem
    {
        private List<IObservador> inimigos = new List<IObservador>();        
        public int vida = 100;

        public void NotificarPersonagens()
        {
            foreach (IObservador i in inimigos)
            {
                i.Avisar(this);
            }
        }

        public void RegistrarObservador(IObservador i)
        {
            inimigos.Add(i);
        }
      
        public void Golpe_Acertado(bool golpe)
        {
            if (golpe)
                vida -= 10;

            NotificarPersonagens();
        }

        public int getVida()
        {
            return vida;
        }
    }
}
