using ExercicioDesenho.src;
using System;

namespace ExercicioDesenho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atividade 08/04/2022");
            Console.WriteLine("Exercício de Desenho");
            
            
            Cachorro floquinho = new Cachorro("Floquinho", 5, "azul", "Pequeno");
            Console.WriteLine($"O nome do cachorro é {floquinho.Nome}, O peso é {floquinho.Peso}kg, A cor é {floquinho.Cor}, O tamanho é {floquinho.Tamanho}.");

            floquinho.Comer();

            Cachorro beth = new Cachorro("Beth", 9, "Preta", "Pequena");
            Console.WriteLine($"O nome do cachorro é {beth.Nome}, O peso é {beth.Peso}kg, A cor é {beth.Cor}, O tamanho é {beth.Tamanho}.");
            
            beth.Dormir();
           

        }
    }
}
