using System;


namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorNuvens gerenciador_de_nuvens = new GerenciadorNuvens();

            gerenciador_de_nuvens["padrão"] = new NuvemUm("branco", "azul");
            gerenciador_de_nuvens["personalizada"] = new NuvemUm("branco", "laranja");
            
            NuvemUm um   = gerenciador_de_nuvens["padrão"].Clone() as NuvemUm;
            NuvemUm dois = gerenciador_de_nuvens["padrão"].Clone() as NuvemUm;
            NuvemUm tres = gerenciador_de_nuvens["personalizada"].Clone() as NuvemUm;
          
            Console.ReadKey();
        }
    }
}
