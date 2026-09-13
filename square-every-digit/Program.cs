/* Dado un número, el nuevo número es la concatenación
 * de cada dígito elevado al cuadrado.
 */

using System;

public class Kata
{
    public static int SquareDigits(int n)
    {
        string stringNumber = n.ToString();
        string squareString = "";

        for(int i = 0; i < stringNumber.Length; i++)
        {
            int digit = int.Parse(stringNumber[i].ToString());
            digit *= digit;
            squareString += digit.ToString();
        }

        return int.Parse(squareString);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Kata.SquareDigits(0));
        Console.WriteLine(Kata.SquareDigits(9119));
        Console.WriteLine(Kata.SquareDigits(2091));
    }
}