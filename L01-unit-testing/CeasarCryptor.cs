using System.Text;

namespace L01_unit_testing;

public class CeasarCryptor
{
    private const int DefaultShift = 3;
    private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public string Encrypt(string text) => text
        .Select(GetEncryptedChar)
        .Aggregate(new StringBuilder(), (builder, @char) => builder.Append(@char))
        .ToString();

    public string Decrypt(string text) => text
        .Select(GetDecryptedChar)
        .Aggregate(new StringBuilder(), (builder, @char) => builder.Append(@char))
        .ToString();

    private char GetEncryptedChar(char @char)
    {
        var index = Alphabet.IndexOf(@char, StringComparison.OrdinalIgnoreCase);
        var encryptedChar = Alphabet[index + DefaultShift];
        return char.IsLower(@char) ? char.ToLower(encryptedChar) : char.ToUpper(encryptedChar);
    }

    private char GetDecryptedChar(char @char)
    {
        var index = Alphabet.IndexOf(@char, StringComparison.OrdinalIgnoreCase);
        var encryptedChar = Alphabet[index - DefaultShift];
        return char.IsLower(@char) ? char.ToLower(encryptedChar) : char.ToUpper(encryptedChar);
    }
}