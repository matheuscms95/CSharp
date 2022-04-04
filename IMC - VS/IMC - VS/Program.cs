using System;

namespace IMC___VS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float altura, peso, imc;
            
            Console.WriteLine("Olá digite aqui o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Entre com sua altura: ");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu peso: ");
            peso = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);
            Console.WriteLine("Temos o resultado!" + "\n" + nome + "." + " O seu IMC atual é: " + imc);
        }
    }
}
