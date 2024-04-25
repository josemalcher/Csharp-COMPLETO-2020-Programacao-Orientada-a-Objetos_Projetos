// See https://aka.ms/new-console-template for more information

using System.Data.Common;
using System.Globalization;
using vetor2;

int n = int.Parse(Console.ReadLine());

Product[] vect = new Product[n];

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    vect[i] = new Product {Name = name, Price = price};
}

double sum = 0.0;

for (int i = 0; i < n; i++)
{
    sum += vect[i].Price;
}

double avg = sum / n;
Console.WriteLine("Média = " + avg.ToString("F2", CultureInfo.InvariantCulture));
