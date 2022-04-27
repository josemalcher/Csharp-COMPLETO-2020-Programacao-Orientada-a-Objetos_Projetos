// See https://aka.ms/new-console-template for more information

using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using SolutionSecao05Revisao;

Produto p = new Produto("TV", 500.00, 10);

p.Nome = "TV 4k";

Console.WriteLine(p.Nome);