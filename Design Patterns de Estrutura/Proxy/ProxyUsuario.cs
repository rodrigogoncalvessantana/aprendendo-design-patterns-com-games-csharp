using System;

namespace Proxy
{
    public class ProxyUsuario : IJogo
    {
        FaseJogo fasejogo;
        string password = "123";

        public string Consultar()
        {
            if (this.fasejogo != null)
                return fasejogo.Consultar();

            return "Informe o PASSWORD correto para abrir a fase do jogo!";
        }

        public string InformarPassword(string codigo)
        {
            if(codigo == this.password)
            {
                this.fasejogo = new FaseJogo();
                return "Password Correto!";
            }

            return "Password Incorreto!";
        }
    }
}
