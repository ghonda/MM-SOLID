namespace LSP_Violacao
{
    class ContaPoupanca : Conta
    {
        public override void Saque(double valor)
        {
            if (Saldo > valor)
            {
                Saldo -= valor;
            }
        }
    }
}
