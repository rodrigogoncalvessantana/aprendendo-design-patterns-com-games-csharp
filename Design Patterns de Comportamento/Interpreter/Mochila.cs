using System;

namespace Interpreter
{
    public class Mochila : IExpressao
    {
        private IFerramenta ferramenta_principal;
        private IFerramenta ferramenta_secundaria;
        private IArmamento armamento;

        public Mochila(IFerramenta ferramenta_principal, IFerramenta ferramenta_secundaria, IArmamento armamento)
        {
            this.ferramenta_principal = ferramenta_principal;
            this.ferramenta_secundaria = ferramenta_secundaria;
            this.armamento = armamento;            
        }

        public void Interpretar(Contexto contexto)
        {            
            contexto.Conteudo += "Abrindo mochila... \n";                        
            armamento.Interpretar(contexto);            
            contexto.Conteudo += "- 1º Ferramenta";
            ferramenta_principal.Interpretar(contexto);
            contexto.Conteudo += "- 2º Ferramenta";
            ferramenta_secundaria.Interpretar(contexto);                              
            contexto.Conteudo += "\n... Fechando mochila"; 
            
            Console.WriteLine(contexto.Conteudo);
        }
    }
}
