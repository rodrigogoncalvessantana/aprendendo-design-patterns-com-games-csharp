using System;

namespace Command
{
    public class SimplesComando : ICommand
    {
        private string _solicitacao = string.Empty;

        public SimplesComando(string solicitacao)
        {
            this._solicitacao = solicitacao;
        }

        public void Executar()
        {
            Console.WriteLine("Estou executando Comando de " + this._solicitacao);

        }
    }
}
