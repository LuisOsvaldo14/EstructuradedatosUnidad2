using System;
using System.Net.Http.Headers;

class contarpares
{
    static void Main()
    {
        Console.WriteLine("Este es un programa que solicita 5 numeros al usuario y calcula su media aritmetica");


        int suma = 0;
        int acumulador = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Introduce tu numero{i}: ");
            int Numero = Convert.ToInt32(Console.ReadLine());
            acumulador = acumulador + Numero; 
        }
        int media = acumulador / 5;
        Console.WriteLine($"La media aritmetica de los 5 numeros que introdugiste es {media}");
    }
}
