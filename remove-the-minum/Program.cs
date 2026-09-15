/* Dado un array de enteros, elimina el valor más pequeño sin
 * mutar el array/lista original. Si hay varios elementos con el
 * mismo valor, elimina el que tenga el índice más bajo.
 * Si tienes un array/lista vacío, lo devuelvo vacío.
 * No puedo cambiar el orden.
 */

using System;
using System;
using System.Collections.Generic;

public class Remover
{
    public static List<int> RemoveSmallest(List<int> numbers)
    {
        List<int> newNumbers = new List<int>(numbers);

        if (newNumbers.Count == 0)
        {
            return newNumbers;
        }

        int min = newNumbers[0];

        foreach(int number in newNumbers)
        {
            if (min > number)
            {
                min = number;
            }
        }

        newNumbers.Remove(min);

        return newNumbers;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<int> score1 = new List<int>()
        {
            1, 2, 3, 4, 5
        };

        Console.WriteLine("Lista 1:\n");

        foreach(int number in Remover.RemoveSmallest(score1))
        {
            Console.Write($"{number} ,");
        }

        Console.WriteLine("\nLista 2:\n");

        List<int> score2 = new List<int>()
        {
            5, 3, 2, 1, 4
        };

        foreach (int number in Remover.RemoveSmallest(score2))
        {
            Console.Write($"{number}, ");
        }

        Console.WriteLine("\nLista 3:\n");

        List<int> score3 = new List<int>()
        {
            2, 2, 1, 2, 1
        };

        foreach (int number in Remover.RemoveSmallest(score3))
        {
            Console.Write($"{number}, ");
        }
    }
}