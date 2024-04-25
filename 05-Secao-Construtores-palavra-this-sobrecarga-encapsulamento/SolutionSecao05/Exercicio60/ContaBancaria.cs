using System;
using System.Globalization;

namespace Exercicio60
{
    public class ContaBancaria
    {
        public int Conta{get; private set;}
        public string Nome{get; set;}
        public double Saldo{get; private set;}

        public ContaBancaria(string nome, int conta)
        {
            Conta = conta;
            Nome = nome;
        }
        public ContaBancaria(string nome, int conta, double saldo) : this (nome, conta)
        {
            Saldo = saldo;
        }
        
        public void Deposito(double saldo)
        {
            Saldo += saldo;
        }
        public void Saque(double retirada)
        {
            Saldo -= retirada + 5.0;
        }
        public override string ToString() {
            return "Conta "
                + Conta
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}