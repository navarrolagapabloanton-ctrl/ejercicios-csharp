/* La idea principal es contar la cantidad de todos los carácteres
 * en un string dado como un Dictionary.
 * Si tú tienes un string como "aba", entonces el resultado sería:
 * {'a': 2, 'b': 1}.
 * Y si el dictionary está vacío se devuelve un dictionary vacío.
 */

using System.Collections.Generic;
using System;

public class Kata
{
    public static Dictionary<char, int> Count(string str)
    {
        Dictionary<char, int> dictionary = new Dictionary<char, int>();
        char repeatCharacter;
        int charCounter = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (!dictionary.ContainsKey(str[i]))
            {
                repeatCharacter = (str[i]);

                for (int f = 0; f < str.Length; f++)
                {
                    if (str[f] == repeatCharacter)
                    {
                        charCounter++;
                    }
                }

                dictionary.Add(repeatCharacter, charCounter);

                charCounter = 0;
            }
        }

        return dictionary; 
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\nPrueba 1:\n");

        foreach (KeyValuePair<char, int> valor in Kata.Count("aba"))
        {
            Console.WriteLine($"Letra:{valor.Key} - " +
                $" Contador: {valor.Value}.");
        }

        Console.WriteLine("\nPrueba 2:\n");

        foreach (KeyValuePair<char, int> valor in Kata.Count("Mi coche está cerrado."))
        {
            Console.WriteLine($"Letra:{valor.Key} - " +
                $" Contador: {valor.Value}.");
        }
    }
}