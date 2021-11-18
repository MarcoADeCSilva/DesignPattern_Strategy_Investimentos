using DesignPattern_Strategy_Investimentos.Dominio;
using DesignPattern_Strategy_Investimentos.Infraestrutura.Investimentos;
using DesignPattern_Strategy_Investimentos.Interface;
using DesignPattern_Strategy_Investimentos.Servico;
using System;

namespace DesignPattern_Strategy_Investimentos
{
    class Program
    {
        static void Main(string[] args)
        {
            IInvestimento conservador = new Conservador();
            IInvestimento moderado = new Moderado();
            IInvestimento arrojado = new Arrojado();

            ContaBancaria contaBancaria = new ContaBancaria(1000);
            RealizadorDeInvestimentos investimentos = new RealizadorDeInvestimentos();

            double chanceDeAcontecer = new Random().Next(101);

            investimentos.CalculaLucroAposInvestimento(contaBancaria, conservador, chanceDeAcontecer);

            Console.WriteLine("-------------------------------------");

            investimentos.CalculaLucroAposInvestimento(contaBancaria, moderado, chanceDeAcontecer);

            Console.WriteLine("-------------------------------------");

            investimentos.CalculaLucroAposInvestimento(contaBancaria, arrojado, chanceDeAcontecer);

            Console.ReadKey();
        }
    }
}
