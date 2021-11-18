using DesignPattern_Strategy_Investimentos.Dominio;
using DesignPattern_Strategy_Investimentos.Interface;

namespace DesignPattern_Strategy_Investimentos.Infraestrutura.Investimentos
{
    public class Conservador : IInvestimento
    {
        public double CalculaLucro(ContaBancaria contaBancaria, double chanceAcontecer)
        {
            return contaBancaria.Saldo * 0.008;
        }
    }
}
