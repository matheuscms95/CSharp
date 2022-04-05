using System;

namespace Alua3VSC
{
    class Program
    {
        static void Main(string[] args)
        {
            float altura, imc, peso;

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua altura: ");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu peso: ");
            peso = float.Parse(Console.ReadLine());

            imc = (peso / (altura * altura));
            
            Console.WriteLine("Temos o resultado " + nome + "\nSeu IMC é: " + imc);
            
        }
    }
}
