/* Dados dos números enteros (edad, clasificación), dar una
 * salida string que diga si es Open o Senior.
 * Open: < 55 años.
 * Senior: >=55 años más de 7 de clasificación/hándicap.
 * Hándicap va de -2 a 26.
 */

using System;
using System.Collections.Generic;

public class Kata
{
    public static IEnumerable<string> OpenOrSenior(int[][] data)
    {
        List<string> list = new List<string>();

        for (int i = 0; i < data.Length; i++)
        {
            list.Add(data[i][0] >= 55 && data[i][1] > 7 ?
                "Senior" : "Open");
        }

        return list;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int[][] array = { [18, 20], [45, 2], [61, 12], [37, 6],
        [21, 21], [78, 9] };

        foreach (string member in Kata.OpenOrSenior(array))
        {
            Console.WriteLine(member);
        }
    }
}