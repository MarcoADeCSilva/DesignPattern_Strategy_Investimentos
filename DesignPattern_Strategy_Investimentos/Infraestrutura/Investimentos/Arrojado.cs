using DesignPattern_Strategy_Investimentos.Dominio;
using DesignPattern_Strategy_Investimentos.Interface;

namespace DesignPattern_Strategy_Investimentos.Infraestrutura.Investimentos
{
    public class Arrojado : IInvestimento
    {
        public double CalculaLucro(ContaBancaria contaBancaria, double chanceAcontecer)
        {
            if (chanceAcontecer <= 20)
                return contaBancaria.Saldo * 0.05;
            else if (chanceAcontecer > 20 && chanceAcontecer <= 30)
                return contaBancaria.Saldo * 0.03;
            else
                return contaBancaria.Saldo * 0.006;
        }
    }
}
