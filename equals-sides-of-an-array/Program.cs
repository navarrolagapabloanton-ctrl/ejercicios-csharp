/* Dado un array de int tu trabajo es tomar el array y encontrar un
 * índice N donde la suma de los enteros de izquierda a N es igual a
 * la suma de los enteros de derecha a N.
 * Si no hay índice que suceda, se devuele -1.
 */

public class Kata
{
    public static int FindEvenIndex(int[] arr)
    {
        int leftSum = 0;
        int rightSum = 0;

        for(int i = 0; i < arr.Length; i++)
        {

            leftSum = 0;
            rightSum = 0;

            for (int f = 0; f < i; f++)
            {
                leftSum += arr[f];
            }

            for (int h = arr.Length - 1; h > i; h--)
            {
                rightSum += arr[h];
            }

            if (leftSum == rightSum)
            {
                return i;
            }
        }

        return -1;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int[] array1 = { 1, 2, 3, 4, 3, 2, 1 };
        int[] array2 = { 1, 100, 50, -51, 1, 1 };
        int[] array3 = { 20, 10, -80, 10, 10, 15, 35 };
        int[] array4 = { 0, 0, 0, 0, 0 };

        Console.WriteLine(Kata.FindEvenIndex(array1));
        Console.WriteLine(Kata.FindEvenIndex(array2));
        Console.WriteLine(Kata.FindEvenIndex(array3));
        Console.WriteLine(Kata.FindEvenIndex(array4));
    }
}