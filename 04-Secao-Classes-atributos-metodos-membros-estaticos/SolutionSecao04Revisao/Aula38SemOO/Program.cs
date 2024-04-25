// See https://aka.ms/new-console-template for more information

using System.Globalization;
using Aula38SemOO;

// double xA, xB, xC, yA, yB, yC;
Triangulo x, y;

x = new Triangulo();
y = new Triangulo();

Console.WriteLine("Entre com as medidas do triângulo X:");
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triângulo Y:");
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// double p = (x.A + x.B + x.C) / 2.0;
double areaX = x.Area();

// p = (y.A + y.B + y.C) / 2.0;

double areaY = y.Area();

Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

if (areaX > areaY) {
    Console.WriteLine("Maior área: X");
}
else {
    Console.WriteLine("Maior área: Y");
}