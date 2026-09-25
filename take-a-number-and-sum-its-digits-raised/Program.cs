/* El número 89 es el primer entero con más de un dígito que crea
 * esta operación matemática 89 = 8¹ + 9². Y el siguiente número
 * es 135: 135 = 1¹ + 3² + 5³.
 * Necesitamos una función que pueda recibir dos enteros y,
 * dentro del rango de los dos números de la entrada (inclusives),
 * devuelva una lista de números ordenados donde salgan todos
 * los números que cumplan la condición anteriormente mencionada.
 * Si no hay números en ese rango debería de devolver una lista
 * vacía.
 */

using System;
using System.Collections.Generic;

public class SumDigPower
{
    public static long[] SumDigPow(long a, long b)
    {
        long min;
        long max;

        if (a < b)
        {
            min = a;
            max = b;
        }
        else if (a > b)
        {
            max = a;
            min = b;
        }
        else
        {
            min = a;
            max = b;
        }

        List<long> result = new List<long>();

        for (long i = min; i <= max; i++)
        {
            string stringNumber = i.ToString();
       
            long digit = 0;
            long digitPowSumResult = 0;

            for (int f = 0; f < stringNumber.Length; f++)
            {
                digit = stringNumber[f] - '0';
                digit = (long)Math.Pow(digit, f + 1);

                digitPowSumResult += digit;
            }

            if (i == digitPowSumResult)
            {
                result.Add(i);
            }
        }

        return result.ToArray();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\nEjemplo 1: \n");

        foreach(long digit in SumDigPower.SumDigPow(1, 10))
        {
            Console.WriteLine(digit);
        }

        Console.WriteLine("\nEjemplo 2: \n");

        foreach (long digit in SumDigPower.SumDigPow(1, 100))
        {
            Console.WriteLine(digit);
        }

        Console.WriteLine("\nEjemplo 3: \n");

        foreach (long digit in SumDigPower.SumDigPow(10, 100))
        {
            Console.WriteLine(digit);
        }

        Console.WriteLine("\nEjemplo 4: \n");

        foreach (long digit in SumDigPower.SumDigPow(90, 100))
        {
            Console.WriteLine(digit);
        }

        Console.WriteLine("\nEjemplo 5: \n");

        foreach (long digit in SumDigPower.SumDigPow(90, 150))
        {
            Console.WriteLine(digit);
        }

        Console.WriteLine("\nEjemplo 6: \n");

        foreach (long digit in SumDigPower.SumDigPow(50, 150))
        {
            Console.WriteLine(digit);
        }

        Console.WriteLine("\nEjemplo 7: \n");

        foreach (long digit in SumDigPower.SumDigPow(10, 150))
        {
            Console.WriteLine(digit);
        }
    }
}