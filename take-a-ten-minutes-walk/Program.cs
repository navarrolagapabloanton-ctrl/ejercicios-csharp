/* Cada vez que presionas un botón te devuelve un
 * array de strings con una letra que marca una dirección
 * ("n", "s", "w", "e"). Toma un minuto terminar de andar
 * esa direccíón.
 * Crea una función que devuelva true si la app te da
 * exactamente 10 minutos volviendo a tu punto de partida.
 */

public class Kata
{
    public static bool IsValidWalk(string[] walk)
    {
        int nCounter = 0;
        int sCounter = 0;
        int eCounter = 0;
        int wCounter = 0;

        if (walk.Length != 10)
        {
            return false;
        }
        else
        {
            foreach (string direction in walk)
            {
                if (direction == "n")
                {
                    nCounter++;
                }
                else if (direction == "s")
                {
                    sCounter++;
                }
                else if (direction == "e")
                {
                    eCounter++;
                }
                else if (direction == "w")
                {
                    wCounter++;
                }
            }
        }

        return (nCounter - sCounter == 0
               && eCounter - wCounter == 0);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        string[] array1 = { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" };
        string[] array2 = { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" };
        string[] array3 = { "w" };
        string[] array4 = { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" };

        Console.WriteLine(Kata.IsValidWalk(array1));
        Console.WriteLine(Kata.IsValidWalk(array2));
        Console.WriteLine(Kata.IsValidWalk(array3));
        Console.WriteLine(Kata.IsValidWalk(array4));
    }
}