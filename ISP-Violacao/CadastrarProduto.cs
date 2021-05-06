using System;

namespace ISP_Violacao
{
    public class CadastrarProduto : IPersistencia
    {
        //A classe CadastrarProduto não tem implementação de enviar email
        //porém, a interface obriga a classe a implementar o método
        public void EnviarEmail()
        {
            throw new NotImplementedException();
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
