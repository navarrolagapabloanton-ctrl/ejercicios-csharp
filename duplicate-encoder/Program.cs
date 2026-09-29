/* El objetivo de este ejercicio es convertir un string en un nuevo
 * string donde cada letra en el nuevo string es "(" si la letra
 * aparece sólo una vez en el string original o ")" si esa letra
 * aparece más de una vez en el string original. Ignora las mayúsculas
 * si la letra está duplicada.
 */

using System.Linq;

public class Kata
{
    public static string DuplicateEncode(string word)
    {
        word = word.ToLower();

        string newWord = "";

        foreach (char character in word)
        {
            if (word.Count(s => s == character) > 1)
            {
                newWord += ')';
            }
            else
            {
                newWord += '(';
            }
        }

        return newWord;
    }
}


public class Program
{ 
    public static void Main(string[] args)
    {
        Console.WriteLine(Kata.DuplicateEncode("din"));
        Console.WriteLine(Kata.DuplicateEncode("recede"));
        Console.WriteLine(Kata.DuplicateEncode("Success"));
        Console.WriteLine(Kata.DuplicateEncode("(( @"));

    }
}