using DesignPattern_Strategy_Investimentos.Dominio;
using DesignPattern_Strategy_Investimentos.Interface;

namespace DesignPattern_Strategy_Investimentos.Infraestrutura.Investimentos
{
    public class Moderado : IInvestimento
    {
        public double CalculaLucro(ContaBancaria contaBancaria, double chanceAcontecer)
        {
            if (chanceAcontecer <= 50)
                return contaBancaria.Saldo * 0.025;
            else
                return contaBancaria.Saldo * 0.007;
        }
    }
}
