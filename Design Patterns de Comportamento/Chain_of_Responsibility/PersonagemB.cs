using System;

namespace Chain_of_Responsibility
{
    public class PersonagemB : Manipulador
    {
        public override void Convoca(int quantidadePoder)
        {
            if (quantidadePoder >= 10 && quantidadePoder < 20)
                Console.WriteLine("{0} convocado para uma força de poder de {1}", this.GetType().Name, quantidadePoder);
            else if (sucessor != null)
                sucessor.Convoca(quantidadePoder);
        }
    }
}
