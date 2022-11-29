using System;
using Classes.src;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
           Pessoa Michelli = new Pessoa("Michelli", "Branca", 1.61, "Castanhos");
           Pessoa Leonardo = new Pessoa("Leonardo", "Branca", 1.80, "Castanhos");
           Pessoa Maria = new Pessoa("Maria", "Negra", 1.50, "Preto");

           Console.WriteLine($"O primeiro nome é {Michelli.Nome}, de cor da pele {Michelli.CorDaPele}, altura {Michelli.Tamanho} e cor dos olhos {Michelli.CorOlhos} .");

           Console.WriteLine($"O primeiro nome é {Leonardo.Nome}, de cor da pele {Leonardo.CorDaPele}, altura {Leonardo.Tamanho} e cor dos olhos {Leonardo.CorOlhos} .");

           Console.WriteLine($"O primeiro nome é {Maria.Nome}, de cor da pele {Maria.CorDaPele}, altura {Maria.Tamanho} e cor dos olhos {Maria.CorOlhos} .");

        }
    }
}
