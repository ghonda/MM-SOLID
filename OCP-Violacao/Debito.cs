namespace OCP_Violacao
{
    public enum TipoDebito { ContaCorrente, Poupanca }
    internal class Debito
    {
        public void Debitar(double valor, TipoDebito tipo)
        {
            if (tipo == TipoDebito.Poupanca)
            {
                // Debita Poupanca
            }
            else if (tipo == TipoDebito.ContaCorrente)
            {
                // Debita ContaCorrente
            }
        }
    }
}
