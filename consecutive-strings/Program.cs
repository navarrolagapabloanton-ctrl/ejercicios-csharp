/* Dado un array de strings y un entero k. Tu tarea es devolver el
 * primer string más grande formado por unir k palabras del array
 * en orden.
 */

public class LongestConsecutives
{
    public static string LongestConsec(string[] strarr, int k)
    {
        string longestWord = "";
        int n = strarr.Length;

        if (n == 0 || k > n || k <= 0)
        {
            return "";
        }

        for (int i = 0; i < n; i++)
        {
            string newWord = strarr[i];

            if (n >= i + k)
            {
                newWord = "";

                for (int f = i; f < i + k; f++)
                {
                    newWord += strarr[f];
                }
            }

            if (newWord.Length > longestWord.Length)
            {
                longestWord = newWord;
            }
        }

        return longestWord;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        string[] array1 = { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" };
        string[] array2 = { "ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh" };
        string[] array3 = { };
        string[] array4 = { "itvayloxrp", "wkppqsztdkmvcuwvereiupccauycnjutlv", "vweqilsfytihvrzlaodfixoyxvyuyvgpck" };
        string[] array5 = { "wlwsasphmxx", "owiaxujylentrklctozmymu", "wpgozvxxiu" };
        string[] array6 = { "zone", "abigail", "theta", "form", "libe", "zas" };
        string[] array7 = { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" };
        string[] array8 = { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" };
        string[] array9 = { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" };

        Console.WriteLine(LongestConsecutives.LongestConsec(array1, 2));
        Console.WriteLine(LongestConsecutives.LongestConsec(array2, 1));
        Console.WriteLine(LongestConsecutives.LongestConsec(array3, 3));
        Console.WriteLine(LongestConsecutives.LongestConsec(array4, 2));
        Console.WriteLine(LongestConsecutives.LongestConsec(array5, 2));
        Console.WriteLine(LongestConsecutives.LongestConsec(array6, -2));
        Console.WriteLine(LongestConsecutives.LongestConsec(array7, 3));
        Console.WriteLine(LongestConsecutives.LongestConsec(array8, 15));
        Console.WriteLine(LongestConsecutives.LongestConsec(array9, 0));
    }
}