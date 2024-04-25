using System;
using System.Globalization;

namespace Exercicio60
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaJose;

            Console.Write("Entre com o número da conta: ");
            int conta =  int.Parse(Console.ReadLine());

            Console.Write("Entre com o Titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá Deposito Inicial?(s/n): ");
            char depInicial = char.Parse(Console.ReadLine());

            if(depInicial == 's' || depInicial == 'S'){
                Console.Write("Entre com o valor do Deposito: ");
                double saldo =  double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaJose = new ContaBancaria(nome, conta, saldo);
                Console.WriteLine(contaJose);
            }else{
                contaJose = new ContaBancaria(nome, conta);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(contaJose);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaJose.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaJose);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaJose.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaJose);
          
            
            
        }
    }
}
