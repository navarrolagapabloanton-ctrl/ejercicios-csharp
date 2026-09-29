/* Algunos números tienen propiedades divertidas. Por ejemplo:
 * 
 * 89 --> 8¹ + 9² = 89 * 1.
 * 695 --> 6² + 9³ + 5⁴ = 1390 = 695 * 2.
 * 46288 --> 4³ + 6⁴ + 2⁵ + 8⁶ + 8⁷ = 2360688 = 46288 * 51.
 * 
 * Dados dos enteros positivos (n, p), nosotros queremos encontrar un
 * entero positivo k. Si existe, este es la suma de los dígitos de
 * n elevados a las potencias consecutivamente empezando por p es
 * igual a k * n.
 * 
 * En otras palabras, escribiendo los números consecutivos de n como
 * a, b, c, d... da un entero k tal que:
 * 
 * (aᵖ + bᵖ⁺¹ + cᵖ⁺² + dᵖ⁺³ + ...) = n * k
 * 
 * Si es el caso devolverá k, sino -1.
 * 
 * Nota: n y p siempre serán números positivos.
 */

using System;
public class DigPow
{
    public static long digPow(int n, int p)
    {
        string numberN = n.ToString();
        long digit;
        long result = 0;

        for (int i = 0; i < numberN.Length; i++)
        {
            digit = long.Parse(numberN[i].ToString());
            result += (long)Math.Pow(digit, p + i);
        }

        if (result % n == 0)
        {
            long k = result / n;

            return k;
        }
        else
        {
            return -1;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(DigPow.digPow(89, 1));
        Console.WriteLine(DigPow.digPow(92, 1));
        Console.WriteLine(DigPow.digPow(695, 2));
        Console.WriteLine(DigPow.digPow(46288, 3));
    }
}