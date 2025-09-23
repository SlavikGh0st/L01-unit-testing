using NUnit.Framework;

namespace L01_unit_testing;

public class CeasarCryptorTests
{
    [Test]
    public void Encrypt_LowerCase()
    {
        const string text = "abc";
        const string expected = "def";
        var encryptor = new CeasarCryptor();

        var actual = encryptor.Encrypt(text);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Encrypt_UpperCase()
    {
        const string text = "ABC";
        const string expected = "DEF";
        var encryptor = new CeasarCryptor();

        var actual = encryptor.Encrypt(text);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Decrypt_LowerCase()
    {
        const string text = "def";
        const string expected = "abc";
        var encryptor = new CeasarCryptor();

        var actual = encryptor.Decrypt(text);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Decrypt_UpperCase()
    {
        const string text = "DEF";
        const string expected = "ABC";
        var encryptor = new CeasarCryptor();

        var actual = encryptor.Decrypt(text);

        Assert.That(actual, Is.EqualTo(expected));
    }
}