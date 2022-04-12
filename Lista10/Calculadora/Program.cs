using System;
using Calculadora.src;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Descobrindo as áreas.");

            IFormas formas = new Formas();
            
            Console.WriteLine($"Área do retângulo: {formas.Retangulo(8, 6)}");	
            Console.WriteLine($"Área do quadrado: {formas.Quadrado(7)}");
            Console.WriteLine($"Área do triângulo: {formas.Triangulo(16, 12)}");
        }
    }
}
