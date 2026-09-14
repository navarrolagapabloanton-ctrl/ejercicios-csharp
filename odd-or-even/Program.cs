/* Dada una lista de enteros, determina si la suma de
 * todos sus elementos es impar o par.
 * Devuelve un string.
 * Si el array está vacío ([0]) es par "even".
 */

public class Kata
{
    public static string OddOrEven(int[] array)
    {
        int sum = 0;

        foreach(int number in array)
        {
            sum += number;
        }

        return sum % 2 == 0 ? "even" : "odd";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 0 };
        int[] array2 = { 0, 1, 4 };
        int[] array3 = { 0, -1, -5 };
        int[] emptyArray = { };

        Console.WriteLine(Kata.OddOrEven(array));
        Console.WriteLine(Kata.OddOrEven(array2));
        Console.WriteLine(Kata.OddOrEven(array3));
        Console.WriteLine(Kata.OddOrEven(emptyArray));
    }
}