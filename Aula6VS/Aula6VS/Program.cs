﻿using System;

namespace Aula6VS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;

            for(int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"Posição {i}.\nEntre com o valor que deseja somar a {valor}: ");
                valor += int.Parse(Console.ReadLine());
                // += = Valor = valor + int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Somatoria: {valor}");
        }
    }
}
