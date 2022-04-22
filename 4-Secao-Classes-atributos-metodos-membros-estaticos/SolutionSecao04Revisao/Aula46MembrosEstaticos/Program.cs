// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
namespace Aula46MembrosEstaticos // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Circunferencia(raio);
            double volume = Volume(raio);
            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));

        }
        static double Circunferencia(double r) {
            return 2.0 * Pi * r;
        }
        static double Volume(double r) {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}




