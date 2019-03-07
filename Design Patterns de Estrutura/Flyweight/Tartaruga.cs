namespace Flyweight
{
    //Nossa clase abstrata.
    public abstract class Tartaruga
    {
        //PROTECTED da acesso somente a quem o herdou.
        protected string condicao;         //Aqui temos, nosso atributo Intrínseco.
        protected string acao;             //Aqui temos, nosso atributo Intrínseco.
        public    string cor { get; set; } //Aqui temos, nosso atributo *Extrínseco.

        //Coloca na tela a tartaruga.
        public abstract void Mostra (string cor);

        
        
    }
}