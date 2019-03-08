namespace Bridge
{
    public class Forma1 : IForma
    {
        public ICor ICor { get; set; }

        public string Descer()
        {
            return "T - " + ICor.Cor();
        }        
    }
}
