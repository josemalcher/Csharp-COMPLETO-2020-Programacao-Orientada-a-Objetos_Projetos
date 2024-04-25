using System;
using System.Globalization;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            int y;
            double z;
            char w;            

            x = Console.ReadLine();
            y = int.Parse(Console.ReadLine());
            z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            w = char.Parse(Console.ReadLine());

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(w);

            Console.ReadLine();
        }
    }
}