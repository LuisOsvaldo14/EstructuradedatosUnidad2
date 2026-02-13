using System;

class InvertirLista
{
    static void Main()
    {

        int[] original = { 1, 2, 3, 4, 5 };
        int[] invertida = new int[original.Length];

        Console.WriteLine("Inversión de una Lista");
        Console.WriteLine("Original: " + string.Join(", ", original));

        int j = original.Length - 1;
        for (int i = 0; i < original.Length; i++)
        {
            invertida[j] = original[i];
            j--; 
        }

        Console.WriteLine("Invertida: " + string.Join(", ", invertida));
    }
}
