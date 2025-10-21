using System.Text;

namespace L01_unit_testing;

public class CeasarCryptor
{
    private const int DefaultShift = 3;
    private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public string Encrypt(string text) => GetNewText(text, GetEncryptedChar);

    public string Decrypt(string text) => GetNewText(text, GetDecryptedChar);

    private static string GetNewText(string originalText, Func<char, char> getNewChar) =>
        originalText
            .Select(getNewChar)
            .Aggregate(new StringBuilder(), (builder, @char) => builder.Append(@char))
            .ToString();

    private static char GetEncryptedChar(char originChar) =>
        Alphabet[(GetIndexOfOriginChar(originChar) + DefaultShift) % Alphabet.Length];

    private static char GetDecryptedChar(char originChar)
    {
        var index = GetIndexOfOriginChar(originChar);
        return index >= DefaultShift
            ? Alphabet[index - DefaultShift]
            : Alphabet[Alphabet.Length + index - DefaultShift];
    }

    private static int GetIndexOfOriginChar(char originChar) =>
        Alphabet.IndexOf(originChar, StringComparison.OrdinalIgnoreCase);
}
