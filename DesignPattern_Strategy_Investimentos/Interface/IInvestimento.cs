using DesignPattern_Strategy_Investimentos.Dominio;

namespace DesignPattern_Strategy_Investimentos.Interface
{
    public interface IInvestimento
    {
        double CalculaLucro(ContaBancaria contaBancaria, double chanceAcontecer);
    }
}
