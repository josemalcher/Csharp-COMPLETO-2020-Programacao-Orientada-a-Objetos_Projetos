﻿// See https://aka.ms/new-console-template for more information

using System.Globalization;
using SolutionSecao05Revisao;

Console.WriteLine("Entre os dados do produto:");
Console.Write("Nome: ");
string nome = Console.ReadLine();
Console.Write("Preço: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// Console.Write("Quantidade no estoque: ");
// int quantidade = int.Parse(Console.ReadLine());

// Produto p = new Produto(nome, preco, quantidade);
Produto p = new Produto(nome, preco);

Produto p1 = new Produto {
    Nome = "TV",
    Preco = 900.0,
    Quantidade = 0
};
Produto p2 = new Produto() {
    Nome = "TV",
    Preco = 900.0,
    Quantidade = 0
};
// Isso funciona mesmo se a classe não possuir construtores implementados

Console.WriteLine();
Console.WriteLine("Dados do produto: " + p);
Console.WriteLine();
Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");

int qte = int.Parse(Console.ReadLine());
p.AdicionarProdutos(qte);
Console.WriteLine();
Console.WriteLine("Dados atualizados: " + p);
Console.WriteLine();

Console.Write("Digite o número de produtos a ser removido do estoque: ");
qte = int.Parse(Console.ReadLine());
p.RemoverProdutos(qte);
Console.WriteLine();
Console.WriteLine("Dados atualizados: " + p);