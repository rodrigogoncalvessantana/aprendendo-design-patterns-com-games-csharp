using System;

namespace Command
{
    public class Controle
    {
        private ICommand comandoSimples;
        private ICommand comandoComplexo;

        public void EnviarComandoSimples(ICommand command)
        {
            this.comandoSimples = command;
        }

        public void EnviarComandoComplexo(ICommand command)
        {
            this.comandoComplexo = command;
        }

        public void Fazer()
        {
            Console.WriteLine("Ok, vou executar para você!");
            if (this.comandoSimples is ICommand)
                this.comandoSimples.Executar();
          
            if (this.comandoComplexo is ICommand)
                this.comandoComplexo.Executar();
        }
    }
}