using System;
using System.Collections.Generic;
using Zoologico.src;

namespace Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zoológico");

            List<Animal> animais = new List<Animal>(
                new Animal[] {
                    new Gato("Gato Lua", "Cinza", "Felino"),
                    new Gato("Gato Bob", "Laranja", "Felino"),
                    new Cachorro("Cachorro Chocolate", "Marrom", "Canídio")
                }

            );

            foreach (Animal animal in animais)
            {
                if(animal.Classificacao == "Canídio")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Au au au");
                }
                else if (animal.Classificacao == "Felino")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Miauuu");
                }    
            
            }    
        }
    }
}
