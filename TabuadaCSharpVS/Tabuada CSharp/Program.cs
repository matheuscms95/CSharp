using System;

namespace Tabuada_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            Console.WriteLine("Tabuada dos números!");
            Console.WriteLine("Para começar, entre com o numero desejado: ");
            valor = int.Parse(Console.ReadLine());

            while(valor <= 10)
            {
                for(int y = 1; y <= 10; y++)
                {
                    Console.WriteLine($"{valor} x {y} = {valor * y}");
                }
                break;
            }
        }
    }
}
