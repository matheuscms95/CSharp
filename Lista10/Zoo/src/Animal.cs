using System;

namespace Lista10.src
{
    public class Animal
    {
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public string Cor { get; set; }
        public string Tamanho { get; set; }
        public string Peso { get; set; }

        public Animal() { }

        public Animal(string tipo, string nome, string cor, string tamanho, string peso)
        {
            Tipo = tipo;
            Nome = nome;
            Cor = cor;
            Tamanho = tamanho;
            Peso = peso;
        }

        public virtual void Comunicar(string comunicacao)
        {
            Console.WriteLine($"O {Nome} está falando: {comunicacao}" );
        }
    }
}