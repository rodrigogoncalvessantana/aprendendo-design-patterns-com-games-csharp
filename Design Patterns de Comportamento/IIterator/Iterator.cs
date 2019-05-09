namespace IIterator
{
    public class Iterator : IIterator
    {
        IAggregate colecao = null;
        int atualIndex = 0;

        public Iterator(IAggregate colecao)
        {
            this.colecao = colecao;
        }

        public string primeiroItem
        {
            get
            {
                atualIndex = 0;
                return colecao[atualIndex];
            }
        }

        public string proximoItem
        {
            get
            {
                atualIndex += 1;

                if (estaPronto == false)
                {
                    return colecao[atualIndex];
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public string atualItem
        {
            get
            {
                return colecao[atualIndex];
            }
        }

        public bool estaPronto
        {
            get
            {
                if (atualIndex < colecao.Contador)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
