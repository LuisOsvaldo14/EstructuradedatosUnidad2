using System;
using System.Linq;

class PalindromoPalabra
{
    static void Main()
    {
        Console.WriteLine("--- Verificador de Palíndromos ---");
        Console.Write("Introduce una palabra: ");


        string palabraOriginal = Console.ReadLine().Trim().ToLower();


        char[] caracteres = palabraOriginal.ToCharArray();
        Array.Reverse(caracteres);
        string palabraInvertida = new string(caracteres);

        if (palabraOriginal == palabraInvertida && palabraOriginal != "")
        {
            Console.WriteLine($"La palabra es palíndroma ({palabraOriginal} = {palabraInvertida})");
        }
        else
        {
            Console.WriteLine("La palabra NO es palíndroma.");
        }
    }
}