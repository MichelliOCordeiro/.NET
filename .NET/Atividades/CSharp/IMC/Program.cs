using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            float altura;
            float peso;
            float imc;
            
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua altura: ");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu peso: ");
            peso = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);
            Console.WriteLine("Seu IMC é: " + imc);

            if (imc <18.5) {
            Console.WriteLine("Seu IMC é: "+ imc +"Você esta abaixo do peso");
            }

            else if (imc <25) {
            Console.WriteLine("Seu IMC é: "+ imc +"Você esta com peso normal"); }

            else if (imc <30) {
            Console.WriteLine("Seu IMC é: "+ imc +"Você esta com sobrepeso");}

            else {
             Console.WriteLine("Seu IMC é: " + imc + " Você esta com obesidade");}

        }
    }
}
