using System.Security.Cryptography;
using System.Text;

namespace CSharp11Features;

public static class Encryption
{
    //Solving the Classic FizzBuzz Problem With .NET and C#
    public static string Encrypt(string text, string key)
    {
        var keyBytes = Encoding.UTF8.GetBytes(key);
        var textBytes = Encoding.UTF8.GetBytes(text);
        var encryptedBytes = new byte[textBytes.Length];
        for (int i = 0; i < textBytes.Length; i++)
        {
            encryptedBytes[i] = (byte)(textBytes[i] ^ keyBytes[i % keyBytes.Length]);
        }

        return Convert.ToBase64String(encryptedBytes);
    }
    
    public static string Decrypt(string text, string key)
    {
        var keyBytes = Encoding.UTF8.GetBytes(key);
        var textBytes = Convert.FromBase64String(text);
        var decryptedBytes = new byte[textBytes.Length];
        for (int i = 0; i < textBytes.Length; i++)
        {
            decryptedBytes[i] = (byte)(textBytes[i] ^ keyBytes[i % keyBytes.Length]);
        }

        return Encoding.UTF8.GetString(decryptedBytes);
    }
}