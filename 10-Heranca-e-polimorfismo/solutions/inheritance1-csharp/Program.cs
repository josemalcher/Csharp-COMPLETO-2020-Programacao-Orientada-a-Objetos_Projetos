using System;
using inheritance1_csharp.Entities;

namespace inheritance1_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            BussinessAccount account = new BussinessAccount(123, "Jose", 100.00, 5000);

            Console.WriteLine(account.Balance);

        }
    }
}
