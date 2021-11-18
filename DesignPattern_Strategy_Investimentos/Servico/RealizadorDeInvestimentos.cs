using DesignPattern_Strategy_Investimentos.Dominio;
using DesignPattern_Strategy_Investimentos.Interface;
using System;

namespace DesignPattern_Strategy_Investimentos.Servico
{
    public class RealizadorDeInvestimentos
    {
        public void CalculaLucroAposInvestimento(ContaBancaria contaBancaria, IInvestimento investimento, double chanceDeAcontecer)
        {
            Console.WriteLine($"O Saldo da sua conta bancaria antes do seu investimento é R${contaBancaria.Saldo}.");

            double lucroObtidocomInvestimento = (investimento.CalculaLucro(contaBancaria, chanceDeAcontecer) * 0.75);
            double total = contaBancaria.Saldo + lucroObtidocomInvestimento;

            Console.WriteLine($"Após o investimento {investimento.GetType().Name}, seu Saldo é R${total}.");
        }
    }
}
