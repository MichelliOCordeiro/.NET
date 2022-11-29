using System;
using Calculadora.src;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");

            Calc objeto = new Calc();

            Console.WriteLine($"Area do retângulo: {objeto.AreaRetangulo(10, 5)}");
            
            Console.WriteLine($"Area do quadrado: {objeto.AreaQuadrado(5, 5)} ");

            Console.WriteLine($"Area do triangulo: {objeto.AreaTriangulo(2, 10)}"); 
        }
    }
}
