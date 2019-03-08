namespace Bridge
{
    public class Forma2 : IForma
    {
        public ICor ICor { get; set; }

        public string Descer()
        {
            return "U - " + ICor.Cor();
        }
    }
}
