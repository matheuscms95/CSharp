using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDesenho.src
{
    public class Cachorro 
    {
        public string Nome { get; set; }
        public int Peso { get; set; }
        public string Cor { get; set; }
        public string Tamanho { get; set; }
        
        public Cachorro (string _nome, int _peso, string _cor, string _tamanho) 
        {
            Nome = _nome;
            Peso = _peso;
            Cor = _cor;
            Tamanho = _tamanho;
        }
        
        public void Comer() 
        {
            Console.WriteLine("Estou comendo, ai que delícia.");
        }

        public void Dormir()
        {
            Console.WriteLine("ZzzzZZzZZzzzZ");
        }
    }
}
