using System;

class SumaLista
{
    static void Main()
    {

        int[] numeros = { 10, 25, 5, 12, 8 };

        int sumaTotal = 0;

        Console.WriteLine("Suma de elementos de una lista");
        Console.Write("Elementos en la lista: ");

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write(numeros[i] + " "); 
            sumaTotal += numeros[i];         
        }
        Console.WriteLine($"La suma total de los elementos es: {sumaTotal}");
    }
}
