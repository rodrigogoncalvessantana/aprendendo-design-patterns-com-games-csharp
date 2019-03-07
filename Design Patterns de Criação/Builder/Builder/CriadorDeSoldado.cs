using System;

namespace Builder
{
    public abstract class CriadorDeSoldado
    {
        protected Soldado _soldado;

        public Soldado ObterSoldado()
        {
            return _soldado;
        }

        public abstract void Arma();
        public abstract void Transporte();
        public abstract void Foco();
    }
}
