using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
      {
        string desligar = "0";
        
        Console.WriteLine("Calculadora");
        Console.WriteLine("Para começar, digite ligar: ");
        string ligar = Console.ReadLine();
        if(ligar=="1")
        {
            while(desligar !="0")
            {
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o operador: ");
            string operador = Console.ReadLine();

            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            
            switch(operador)
            {            
                case "+":
            Console.WriteLine("Resultado: " + somar (num1, num2));
            break;
                case "-":
            Console.WriteLine("Resultado: " + subtrair(num1, num2));
            break;
                case "*":
            Console.WriteLine("Resultado: " + multiplicar(num1, num2));
            break;
                case "/":
            Console.WriteLine("Resultado: " + dividir(num1, num2));
            break;
            }
        }
    }    
}    
    Console.WriteLine("Para desligar, digite desligar.");
                desligar=Console.ReadLine();    
    }
}
public static string somar(int num1, int num2)
{
    return (num1 + num2).ToString();
}
public static string subtrair(int num1, int num2)
{
    return (num1 - num2).ToString();
}
public static string multiplicar(int num1, int num2)
{
    return (num1 * num2).ToString();
}
public static string dividir(int num1, int num2)
{
    if(valorDoDividendoMenorOuIgualAZero(num2))
    {
        return "Não é possível dividir por zero ou menor que zero";
    }
    return (num1 / num2).ToString();

    bool valorDoDividendoMenorOuIgualAZero(int num2)
    {
        if (num2 <= 0)
        {
            return true;
        }
            return false; 
      } 
     }
   }
  }
}


