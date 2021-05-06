using System;

namespace ISP_Aderente
{
    public class CadastrarProduto : IPersistencia
    {
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
