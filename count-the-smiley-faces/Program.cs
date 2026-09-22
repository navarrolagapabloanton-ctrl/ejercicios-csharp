/* Dado un array como argumento completa la función que debería
 * devolver el número total de emoticonos sonrientes.
 * Carácteres válidos para estos emoticonos:
 * 1. : o ;
 * 2. - , ~ o nada.
 * 3. ) o D.
 * */

public static class Kata
{
    public static int CountSmileys(string[] smileys)
    {
        int countSmileys = 0;
        bool hasEyes = false;
        bool hasNose = false;
        bool hasMouth = false;

        for (int i = 0; i < smileys.Length; i++)
        {
            hasEyes = false;
            hasNose = false;
            hasMouth = false;

            for (int f = 0; f < smileys[i].Length; f++)
            {
                if (f == 0)
                {
                    if (smileys[i][f] == ':' || smileys[i][f] == ';')
                    {
                        hasEyes = true;
                    }
                }
                else if (f == 1)
                {
                    if (smileys[i][f] == '-' || smileys[i][f] == '~')
                    {
                        hasNose = true;
                    }
                    else if (smileys[i][f] == ')' || smileys[i][f] == 'D')
                    {
                        hasNose = true;
                        hasMouth = true;
                    }
                }
                else if (f == 2)
                {
                    if (smileys[i][f] == ')' || smileys[i][f] == 'D')
                    {
                        hasMouth = true;
                    }
                }

                if (hasEyes && hasNose && hasMouth)
                {
                    countSmileys++;
                }
            }
        }

        return countSmileys;
    }
}

public static class Program
{
    public static void Main(string[] args)
    {
        string[] array = { ":)", ";(", ";}", ":-D" };
        string[] array2 = { ";D", ":-(", ":-)", ";~)" };
        string[] array3 = { ";]", ":[", ";*", ":$", ";-D" };

        Console.WriteLine(Kata.CountSmileys(array));
        Console.WriteLine(Kata.CountSmileys(array2));
        Console.WriteLine(Kata.CountSmileys(array3));
    }
}