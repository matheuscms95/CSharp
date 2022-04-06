using System;

namespace IMC_NOVO
{
    internal class Program
    {
            static void Main(string[] args)
        {
            float peso, altura;

            Console.WriteLine("Qual seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Olá, " + nome + ".\nVamos descobrir o seu IMC!" + "\nPara isso, entre com seu peso: ");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Infome também a sua altura: ");
            altura = float.Parse(Console.ReadLine());

            float imc = peso / (altura * altura);
            
            if (imc < 1)
            {
                imc = imc * 10000;
            }
            if (imc < 18.5)
            {
                Console.WriteLine("Você pode estar Abaixo do peso.");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Você está no Peso normal.");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Você pode estar Acima do peso.");
            }
            else
            {
                Console.WriteLine("Você está desenvolvendo obesidade.");
            }
            Console.WriteLine("O seu IMC atual é: " + imc);
        }
    }
}
