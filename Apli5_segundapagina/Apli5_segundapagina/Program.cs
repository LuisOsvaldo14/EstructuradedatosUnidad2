using System;

class MaximoMinimoLista
{
    static void Main()
    {
        int[] numeros = { 45, 12, 89, 3, 27, 56, -5, 100 };

        int maximo = numeros[0];
        int minimo = numeros[0];

        Console.WriteLine("--- Búsqueda de Máximo y Mínimo ---");
        Console.WriteLine("Lista de números: " + string.Join(", ", numeros));

        for (int i = 1; i < numeros.Length; i++)
        {

            if (numeros[i] > maximo)
            {
                maximo = numeros[i];
            }

            if (numeros[i] < minimo)
            {
                minimo = numeros[i];
            }
        }


        Console.WriteLine($"El valor MÁXIMO es: {maximo}");
        Console.WriteLine($"El valor MÍNIMO es: {minimo}");
    }
}
