namespace DesignPattern_Strategy_Investimentos.Dominio
{
    public class ContaBancaria
    {
        public ContaBancaria(double saldo)
        {
            Saldo = saldo;
        }

        public double Saldo { get; private set; }
    }
}
