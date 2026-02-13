using System;

class PromedioLista
{
    static void Main()
    {

        int[] numeros = { 15, 20, 35, 40, 10 };

        int sumaTotal = 0;

        Console.WriteLine("--- Cálculo del Promedio de una Lista ---");
        Console.Write("Elementos: " + string.Join(", ", numeros));

        for (int i = 0; i < numeros.Length; i++)
        {
            sumaTotal += numeros[i];
        }

        double promedio = (double)sumaTotal / numeros.Length;
        Console.WriteLine("\n");
        Console.WriteLine($"Suma total: {sumaTotal}");
        Console.WriteLine($"Cantidad de elementos: {numeros.Length}");
        Console.WriteLine($"El promedio es: {promedio:F2}"); 
    }
}