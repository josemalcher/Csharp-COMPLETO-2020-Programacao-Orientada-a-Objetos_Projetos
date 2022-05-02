// See https://aka.ms/new-console-template for more information

using System.Globalization;

Console.WriteLine("Entre com os dados");
int n = int.Parse(Console.ReadLine());
double[] vect = new double[n];

for (int i = 0; i < n; i++)
{
    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

double sum = 0.0;

for (int i = 0; i < n; i++)
{
    sum += vect[i];
}

double avg = sum / n;
Console.WriteLine("Average Height = " + avg.ToString("F2", CultureInfo.InvariantCulture));