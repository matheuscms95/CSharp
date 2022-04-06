﻿using System;

namespace Aula5VS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você concluiu o curso (sim ou não): ");
            string condicaoCursoConcluido = Console.ReadLine();
            
            Console.WriteLine("Quantos cursos você concluiu: ");
            int condicaoQuantidadeCursoConcluido = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Você pagou todo o curso (sim ou não): ");
            string condicaoQuitacao = Console.ReadLine();
            
            Console.WriteLine("Você devolveu todos os livros (sim ou não): ");
            string condicaoBiblioteca = Console.ReadLine();

            if (condicaoCursoConcluido == "sim" && 
                condicaoQuantidadeCursoConcluido >= 25 && 
                condicaoQuitacao == "sim" && 
                condicaoBiblioteca == "sim")
            {
                Console.WriteLine("Pode colar grau");
            }
            else
            {
                Console.WriteLine("Não pode colar grau");
            }
        }
    }
}
