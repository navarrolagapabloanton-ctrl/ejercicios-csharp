/* Identificar si un número es el resultado de otro al
 * cuadrado. Devolver true o false.
 */

using System;

public class Kata
{
    public static bool IsSquare(int n)
    {
        int sqrt = (int)Math.Sqrt(n);
        return (int)Math.Pow(sqrt, 2) == n;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingresa un número entero:");

        string? entrada = Console.ReadLine();

        int n;

        while(!int.TryParse(entrada, out n))
        {
            Console.WriteLine("Error. Ingresa un número" +
                " entero.");
            entrada = Console.ReadLine();
        }

        Console.WriteLine(Kata.IsSquare(n));
    }
}