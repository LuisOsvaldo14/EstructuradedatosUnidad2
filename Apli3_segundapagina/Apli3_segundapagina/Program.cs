using System;

class PalindromoPalabra
{
    static void Main()
    {
        Console.WriteLine("--- Verificador de Palíndromos ---");
        Console.Write("Introduce una palabra: ");

        string entrada = Console.ReadLine().ToLower().Replace(" ", "");

        string invertida = "";

        for (int i = entrada.Length - 1; i >= 0; i--)
        {
            invertida += entrada[i];
        }

        if (entrada == invertida && entrada != "")
        {
            Console.WriteLine($"La palabra es palíndroma.");
            Console.WriteLine($"Original: {entrada} | Al revés: {invertida}");
        }
        else
        {
            Console.WriteLine("La palabra NO es palíndroma.");
        }
    }
}