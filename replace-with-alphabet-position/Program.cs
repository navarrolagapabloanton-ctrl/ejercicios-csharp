/* Dado un string, reemplaza cada letra con su posición en el alfabeto.
 * Si algo en el texto no es una letra, ignórala y no devuelvas nada.
 */

public static class Kata
{
    public static string AlphabetPosition(string text)
    {
        string newText = "";
        bool firstSpace = false;

        foreach (char character in text.ToLower())
        {
            if (character >= 'a' && character <= 'z')
            {
                int intCharacter = (int)character - 96;
                string stringCharacter = intCharacter.ToString();

                if (!firstSpace)
                {
                    newText += stringCharacter;
                    firstSpace = true;
                }
                else
                {
                    newText += ' ' + stringCharacter;
                }
            }
        }

        return newText;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Kata.AlphabetPosition("The sunset sets at twelve o' clock."));
    }
}