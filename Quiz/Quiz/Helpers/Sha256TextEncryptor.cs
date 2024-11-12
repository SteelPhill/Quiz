using System;
using System.Security.Cryptography;
using System.Text;

namespace Quiz.Helpers;

public class Sha256TextEncryptor : ITextEncryptor
{
    public string Encrypt(string text)
    {
        var result = new SHA256Managed().ComputeHash(Encoding.Default.GetBytes(text));

        return BitConverter.ToString(result).Replace("-", "").ToLower();
    }
}