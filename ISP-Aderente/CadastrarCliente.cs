using System;

namespace ISP_Aderente
{
    public class CadastrarCliente : IPersistencia, IMensagemEmail
    {
        public void EnviarEmail()
        {
            Console.WriteLine("Enviar email");
        }

        public void SalvarDataBase()
        {
            Console.WriteLine("Salvar Data Base");
        }

        public void ValidarDados()
        {
            Console.WriteLine("Validar Dados");
        }
    }
}
