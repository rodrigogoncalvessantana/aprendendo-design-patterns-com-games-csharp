using System.Collections.Generic;

namespace IIterator
{
    public class Aggregate : IAggregate
    {
        List<string> colecao = null;

        public Aggregate()
        {
            colecao = new List<string>();
        }

        public IIterator GetIterator()
        {
            return new Iterator(this);
        }

        public string this[int indexItem]
        {
            get
            {
                if (indexItem < colecao.Count)
                {
                    return colecao[indexItem];
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                colecao.Add(value);
            }
        }

        public int Contador 
        {
            get
            {
                return colecao.Count;
            }
        }
    }
}
