using NUnit.Framework;

namespace L01_unit_testing;

public class CeasarCryptorTests
{
    [TestCase("abc", "def")]
    [TestCase("XYZ", "ABC")]
    public void Encrypt_WorksCorrectly(string input, string expected)
    {
        var encryptor = new CeasarCryptor();

        var actual = encryptor.Encrypt(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase("def", "abc")]
    [TestCase("ABC", "XYZ")]
    public void Decrypt_WorksCorrectly(string input, string expected)
    {
        var encryptor = new CeasarCryptor();

        var actual = encryptor.Decrypt(input);

        Assert.That(actual, Is.EqualTo(expected));
    }
}