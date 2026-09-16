/* Dado un string de palabras, devuelve el tamaño
 * de la palabra más corta.
 * No se tiene en cuenta strings vacíos.
 */

public class Kata
{
    public static int FindShort(string s)
    {
        string word = "";
        int minLength = s.Length;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != ' ')
            {
                word += s[i];

                if (i == s.Length - 1 || s[i + 1] == ' ')
                {
                    if (minLength > word.Length)
                    {
                        minLength = word.Length;
                    }
                }
            }
            else
            {
                word = "";
            }
        }

        return minLength;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Kata.FindShort("La" +
            " casa donde vamos a vivir es muy" +
            " pequeña pero al menos nos da" +
            " la oportunidad de poder vivir" +
            " juntos."));
    }
}