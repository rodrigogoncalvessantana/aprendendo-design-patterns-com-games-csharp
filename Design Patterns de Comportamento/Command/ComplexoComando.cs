    namespace Command
{
    public class ComplexoComando : ICommand
    {
        private Receiver _receiver;
        private string _a;
        private string _b;

        public ComplexoComando(Receiver receiver, string a, string b)
        {
            this._receiver = receiver;
            this._a = a;
            this._b = b;
        }

        public void Executar()
        {
            this._receiver.PrimeiroPedido(this._a);
            this._receiver.SegundoPedido(this._b);
        }
    }
}
