/* Dados dos números, se suman y se calcula su binario.
 * Se puede sumar antes o después de la conversión a
 * binario.
 * El número binario tiene que ser un string.
 */

using System;

public static class Kata
{
    public static string AddBinary(int a, int b)
    {
        int suma = a + b;

        if (suma == 0)
        {
            return "0";
        }

        string reverseBinaryNumber = "";

        while (suma != 0)
        {
            int rest = suma % 2;
            reverseBinaryNumber += rest;

            suma /= 2;
        }

        string binaryNumber = "";

        for(int i = reverseBinaryNumber.Length -1;
            i >= 0; i--)
        {
            binaryNumber += reverseBinaryNumber[i];
        }

        return binaryNumber;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Kata.AddBinary(1, 1));
    }
}