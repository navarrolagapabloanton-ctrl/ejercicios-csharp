/* Comprueba si una cadena tiene la misma cantidad de 'x' o de 
 * 'o'. El método debe devolver un boolean y no
 * tener en cuenta si es mayúscula o minúscula. La cadena puede
 * contener cualquier carácter. Si hay 0 'x' y 0 'o' es true.
 */

using System.Linq;
using System;

public static class Kata
{
    public static bool XO (string input)
    {
        int counterO = input.Count(c => char.ToLower(c) == 'o');
        int counterX = input.Count(c => char.ToLower(c) == 'x');

        return counterO == counterX;
    }
}

/*public static class Kata
{
    public static bool XO (string input)
    {
        int counterO = 0;
        int counterX = 0;

        foreach(char character in input)
        {
            if (char.ToLower(character) == 'o')
            {
                counterO++;
            }

            if (char.ToLower(character) == 'x')
            {
                counterX++;
            }
        }

        return counterO == counterX;
    }
}
*/

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Kata.XO("ooxx"));
        Console.WriteLine(Kata.XO("xooxx"));
        Console.WriteLine(Kata.XO("ooxXm"));
        Console.WriteLine(Kata.XO("zpzpzpp"));
        Console.WriteLine(Kata.XO("zzoo"));
    }
}