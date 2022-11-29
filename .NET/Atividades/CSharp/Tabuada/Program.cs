using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int tab;

            Console.WriteLine("Tabuada");
            Console.WriteLine("Digite o número que deseja saber a tabuada: ");
            tab= int.Parse(Console.ReadLine ());

            for(int p= 1; p<=10; p++)
                {
                    Console.WriteLine($"{tab} X {p} = {tab*p}");
                }
        }
    }
}
