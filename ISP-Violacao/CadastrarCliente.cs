using System;

namespace ISP_Violacao
{
    public class CadastrarCliente : IPersistencia
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
