using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string decisao, operacao;
            float num1, num2, resultado;
            Console.WriteLine("Calculadora C#");
            Console.WriteLine("Entre com I para iniciar ou S para sair");
            decisao = Console.ReadLine();
            while (decisao.ToLower() != "s")
            {
                Console.WriteLine("Aplicação iniciada.");
                Console.WriteLine("Vamos começar, para isso escolha a operação desejada:");
                Console.WriteLine("1 - Soma, " + "2 - Subtração, " + "3 - Multiplicação, " + "4 - Divisão");
                operacao = Console.ReadLine();
                Console.WriteLine("Entre com o primeiro número");
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Entre com o segundo número");
                num2 = float.Parse(Console.ReadLine());
                resultado = 0;
                switch (operacao.ToLower())
                {
                    case "s":    
                        break;
                    case "i":
                        break;
                    case "1":
                        resultado = num1 + num2;
                        break;
                    case "2":
                        resultado = num1 - num2;
                        break;
                    case "3":
                        resultado = num1 * num2;
                        break;
                    case "4":
                        resultado = num1 / num2;
                        break;
                }
                Console.WriteLine($"Resultado: {resultado}");
                Console.WriteLine("Entre com I para iniciar ou S para sair");
                decisao = Console.ReadLine();
            }
            Console.WriteLine("Aplicação encerrada.");
        }
    }
}
