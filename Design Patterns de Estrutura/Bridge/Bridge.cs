using System;

namespace Bridge
{
    public class Bridge
    {
        public IForma forma_solicitada { get; set; }

        public void ExibeQualFormaEstaDescendoNaTela()
        {
            Console.WriteLine(forma_solicitada.Descer());            
        }       
    }
}
