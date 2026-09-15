/* Dados dos enteros (a, b) que pueden ser positivos o
 * negativos, encuentra la suma de todos los números que
 * hay entre ellos incluyéndose los mismos. Ejemplo:
 * (3, 5) => 3 + 4 + 5 = 12. 
 * (3, -1) => 3 + 2 + 1 + 0 + -1 = 5.
 */

using System;

public class Sum
{
    public int GetSum(int a, int b)
    {
        int sum = a;

        if (a == b)
        {
            return a;
        }
        else if (a < b)
        {
            while (a != b)
            {
                a++;
                sum += a;
            }
        }
        else
        {
            while (a != b)
            {
                a--;
                sum += a;
            }
        }

            return sum;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var sum = new Sum();

        Console.WriteLine(sum.GetSum(3, 5));
        Console.WriteLine(sum.GetSum(3, -1));
        Console.WriteLine(sum.GetSum(1, 0));
        Console.WriteLine(sum.GetSum(1, 2));
        Console.WriteLine(sum.GetSum(0, 1));
        Console.WriteLine(sum.GetSum(1, 1));
        Console.WriteLine(sum.GetSum(-1, 0));
        Console.WriteLine(sum.GetSum(-1, 2));

    }
}