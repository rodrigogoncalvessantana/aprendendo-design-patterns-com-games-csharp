using System;

namespace Interpreter
{
    public class Mochila : IExpressao
    {
        private readonly IFerramenta ferramenta_principal;
        private readonly IFerramenta ferramenta_secundaria;
        private readonly IArmamento armamento;


        public Mochila(IFerramenta ferramenta_principal, IFerramenta ferramenta_secundaria, IArmamento armamento)
        {
            this.ferramenta_principal = ferramenta_principal;
            this.ferramenta_secundaria = ferramenta_secundaria;
            this.armamento = armamento;            
        }

        public void Interpretar(Contexto contexto)
        {            
            contexto.Output += "Abrindo mochila... | ";                        
            armamento.Interpretar(contexto);            
            contexto.Output += ", 1º Ferramenta";
            ferramenta_principal.Interpretar(contexto);
            contexto.Output += " e 2º Ferramenta";
            ferramenta_secundaria.Interpretar(contexto);           
            contexto.Output += " |";           
            contexto.Output += " ... Fechando mochila"; 
            
            Console.WriteLine(contexto.Output);
        }
    }
}
