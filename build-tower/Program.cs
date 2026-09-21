/* Construye una pirámide formada por asteriscos donde
 * la entrada es la cantidad de pisos que tiene la
 * pirámide.
 * La entrada de int tiene que ser números positivos.
 */

public class Kata
{
    public static string[] TowerBuilder(int nFloors)
    {
        string[] newString = new string[nFloors];
        int pyramiBase = nFloors * 2 - 1;
        int middle = pyramiBase / 2;

        for (int i = 0; i < nFloors; i++)
        {
            for (int f = 0; f < pyramiBase; f++)
            {
                if (f >= middle - i && f <= middle + i)
                {
                    newString[i] += "*";
                }
                else
                {
                    newString[i] += " ";
                }
            }
        }

        return newString;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\nTorre nº1: ");

        foreach(string asterisks in Kata.TowerBuilder(3))
        {
            Console.WriteLine(asterisks);
        }

        Console.WriteLine("\nTorre nº2: ");

        foreach (string asterisks in Kata.TowerBuilder(6))
        {
            Console.WriteLine(asterisks);
        }
    }
}