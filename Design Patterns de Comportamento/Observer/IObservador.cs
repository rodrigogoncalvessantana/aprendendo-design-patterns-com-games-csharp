using System;


namespace Observer
{
    public interface IObservador
    {
        void Avisar(IPersonagem personagem);
    }
}
