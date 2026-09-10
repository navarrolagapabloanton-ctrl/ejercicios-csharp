/* De un strig devuelve otro con cada palabra escrita al revés.
 * Los espacios se tienen en cuenta.
 */

using System;

public class Kata
{
    public static string ReverseWords(string str)
    {
        string reverseString = "";
        string word = "";

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != ' ')
            {
                word += str[i];
            }
            else
            {
                reverseString += str[i];
            }

            if ((i < str.Length - 1 && str[i] != ' '
                && str[i + 1] == ' ') || (str[i] != ' '
                && i == str.Length - 1))
            {
                for (int f = word.Length - 1; f >= 0; f--)
                {
                    reverseString += word[f];
                }

                word = "";
            }
        }

        return reverseString;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingresa una frase:");

        string? entrada = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(entrada))
        {
            Console.WriteLine("No puede estar la frase vacía.");
            entrada = Console.ReadLine();
        }

        Console.WriteLine(Kata.ReverseWords(entrada));
    }
}