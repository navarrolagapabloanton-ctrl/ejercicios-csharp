/* Dado un array de int, devuelve el int que aparece
 * un número impar de veces.
 */

using System.Linq;

class Kata
{
    public static int find_it(int[] seq)
    {
        foreach(int number in seq)
        {
            if (seq.Count(n => n == number) % 2 != 0)
            {
                return number;
            }
        }

        return -1;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        int[] array1 = { 7 };
        int[] array2 = { 0 };
        int[] array3 = { 1, 1, 2 };
        int[] array4 = { 0, 1, 0, 1, 0 };
        int[] array5 = { 1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1 };
        int[] array6 = { 20, 1, -1, 2, -2, 3, 3,
            5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };

        Console.WriteLine(Kata.find_it(array1));
        Console.WriteLine(Kata.find_it(array2));
        Console.WriteLine(Kata.find_it(array3));
        Console.WriteLine(Kata.find_it(array4));
        Console.WriteLine(Kata.find_it(array5));
        Console.WriteLine(Kata.find_it(array6));
    }
}