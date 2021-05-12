using System;

namespace SRP_Aderente
{
    static class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido(new RegistraLog(), new EnviarEmail());
            pedido.IncluirPedido();

            Console.ReadLine();
        }
    }
}
