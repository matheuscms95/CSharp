using System;

namespace Lista10.src
{
    public class Rinoceronte : Animal
    {
        public Rinoceronte() { }

        public Rinoceronte(string tipo,string nome, string cor, string tamanho, string peso) : base (tipo, nome, cor, tamanho, peso)
        { }

        public override void Comunicar(string comunicacao)
        {
            Console.WriteLine($"O {Nome} está falando: {comunicacao}");
        }
    }
}