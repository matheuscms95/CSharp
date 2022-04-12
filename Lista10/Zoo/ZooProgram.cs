using System;
using System.Collections.Generic;
using Lista10.src;

namespace Lista10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zoológico");

            List<Animal> animais = new List<Animal>(
                new Animal[]{
                    new Rinoceronte("Rinoceronte", "Jorge", "Cinza", "Grande", "2.000 Kg"),
                    new Giraffa("Giraffa", "Melman", "Amarela", "Grande", "1.500 Kg"),
                    new Elefante("Elefante", "Dumbo", "Preto", "Grande", "2.500 Kg")
                }
            );

            foreach (Animal animal in animais)
            {
                animal.Comunicar("Oi, eu sou um " + animal.Tipo);
            }
        }
    }
}

