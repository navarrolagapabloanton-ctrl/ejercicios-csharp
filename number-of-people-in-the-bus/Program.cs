/* Se me proporciona una lista con un array con dos
 * elementos int. El primer int es la gente que sube
 * al autobús (se suma) y el segundo elemento los que
 * se bajan (se restan). Tiene que devolver el número
 * de personas que siguen en el autobús después de la
 * última parada.
 * El segundo valor en el primer array es 0 ya que
 * está vacío en la primera parada.
 */

using System;
using System.Collections.Generic;

public class Kata
{
    public static int Number(List<int[]> peopleListInOut)
    {
        int peopleEnter = 0;
        int peopleOut = 0;

        for (int i = 0; i < peopleListInOut.Count; i++)
        {
            peopleEnter += peopleListInOut[i][0];
            peopleOut += peopleListInOut[i][1];
        }

        return peopleEnter - peopleOut;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<int[]> pasajeros = [new int[] { 3, 0 },
        new int[] {8 , 3}, new int[] { 5, 6 },
        new int[] {10 , 8}, new int[] { 6, 6 }];

        Console.WriteLine(Kata.Number(pasajeros));
    }
}