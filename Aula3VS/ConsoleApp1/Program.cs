﻿using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Entre com sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Oi " + nome + "," + "\nQue legal que você tem " + idade + " anos de idade.");
        }
    }
}
