namespace OCP_Aderente
{
    public abstract class Debito
    {
        public abstract void Debitar(int valor);
    }

    public class DebitoContaCorrente : Debito
    {
        public override void Debitar(int valor)
        {
            // Debita Conta Corrente
        }
    }

    public class DebitoContaPoupanca : Debito
    {
        public override void Debitar(int valor)
        {
            // Debita Conta Poupança
        }
    }

    public class DebitoContaInvestimento : Debito
    {
        public override void Debitar(int valor)
        {
            // Debita Conta Investimento
        }
    }
}
