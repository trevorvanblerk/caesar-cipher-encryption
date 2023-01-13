using System;

class CaesarCipher
{
    static string Encrypt(string plainText, int shift)
    {
        char[] plainTextArray = plainText.ToCharArray();
        for (int i = 0; i < plainTextArray.Length; i++)
        {
            char letter = plainTextArray[i];
            if (char.IsLetter(letter))
            {
                int newAscii = (int)letter + shift;
                if (char.IsUpper(letter) && newAscii > 90)
                {
                    newAscii = 64 + (newAscii - 90);
                }
                else if (char.IsLower(letter) && newAscii > 122)
                {
                    newAscii = 96 + (newAscii - 122);
                }
                plainTextArray[i] = (char)newAscii;
            }
        }
        return new string(plainTextArray);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a text: ");
        string plainText = Console.ReadLine();
        int shift = 3;
        string cipherText = Encrypt(plainText, shift);
        Console.WriteLine("Plain Text: " + plainText);
        Console.WriteLine("Cipher Text: " + cipherText);
        Console.ReadLine();
    }
}
