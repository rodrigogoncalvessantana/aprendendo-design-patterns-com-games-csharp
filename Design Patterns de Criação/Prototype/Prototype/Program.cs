using System;


namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorNuvens gerenciador_de_nuvens = new GerenciadorNuvens();

            gerenciador_de_nuvens["padrão"] = new NuvemConcreta("branco", "azul");
            gerenciador_de_nuvens["personalizada"] = new NuvemConcreta("branco", "laranja");
            
            NuvemConcreta um   = gerenciador_de_nuvens["padrão"].Clone() as NuvemConcreta;
            NuvemConcreta dois = gerenciador_de_nuvens["padrão"].Clone() as NuvemConcreta;
            NuvemConcreta tres = gerenciador_de_nuvens["personalizada"].Clone() as NuvemConcreta;
          
            Console.ReadKey();
        }
    }
}
