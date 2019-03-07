using System;
using System.Collections.Generic;

namespace Prototype
{
    public class GerenciadorNuvens
    {
        private Dictionary<string, Nuvem> nuvens = new Dictionary<string, Nuvem>();        

        public Nuvem this[string key]
        {
            get { return nuvens[key]; }
            set { nuvens.Add(key, value); }
        }
    }
}
