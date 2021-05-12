using System;

namespace OCP_Violacao
{
    static class Program
    {
        static void Main(string[] args)
        {
            Debito debito = new Debito();

            debito.Debitar(1000, TipoDebito.ContaCorrente);
            debito.Debitar(1000, TipoDebito.Poupanca);

            Console.WriteLine("Principio OCP - Violação");

            Console.ReadLine();
        }
    }
}
