using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//07.Write a program that encodes and decodes a string using given encryption key (cipher). 
//   The key consists of a sequence of characters. The encoding/decoding is done by performing 
//   XOR (exclusive or) operation over the first letter of the string with the first of the key, 
//   the second – with the second, etc. When the last key character is reached, the next is the first.

class EncoderXOR
{
    static void Main()
    {
        string text = "This is the text for encoding and decoding.";
        string key = "The Key";

        Console.Write("07.The encripted text: ");
        string encrypted = Encrypting(text, key);
        Console.WriteLine(encrypted);

        Console.Write("The decripted text: ");
        string deCrypt = Decripting(encrypted, key);
        Console.WriteLine(deCrypt);
        Console.WriteLine();
    }

    static string Encrypting(string str, string key)
    {
        char[] strArray = str.ToCharArray();
        char[] keyArray = new char[strArray.Length];

        StringBuilder encrypted = new StringBuilder();

        for (int i = 0, k = 0; i < keyArray.Length; k++, i++)
        {
            if (!(k < key.Length))
            {
                k = 0;
            }
            keyArray[i] = key[k];
        }
        for (int i = 0; i < strArray.Length; i++)
        {
            encrypted.Append((char)(strArray[i] ^ keyArray[i]));
        }
        return encrypted.ToString();
    }

    static string Decripting (string str, string key)
    {
        return Encrypting(str, key).ToString();
    }
}
