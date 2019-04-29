namespace Strategy
{
    public class Ajuda
    {
        private IAjuda _IAjuda;

        public Ajuda(IAjuda ajuda)
        {
            _IAjuda = ajuda;
        }

        public string Ajudar()
        {
            return _IAjuda.Ajudar(this);
        }
    }
}
