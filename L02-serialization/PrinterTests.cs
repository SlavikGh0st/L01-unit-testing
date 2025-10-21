using FluentAssertions;
using L02_serialization.Models;
using NUnit.Framework;

namespace L02_serialization;

public class PrinterTests
{
    [Test]
    public void PrintToString_PrintPerson()
    {
        var person = new Person("Slava", 33);

        var actual = Printer.PrintToString(person);

        Console.WriteLine(actual);
        actual.Should().Be("Person\r\n\tName = Slava\r\n\tAge = 33");
    }
    
    [Test]
    public void PrintToString_PrintPosition()
    {
        var person = new Person("Slava", 33);
        var pos = new Position("Преподаватель ООП", new DateTime(2025, 9, 1), person);

        var actual = Printer.PrintToString(pos);

        Console.WriteLine(actual);
        actual.Should().Be("Position\r\n\tName = Преподаватель ООП\r\n\tStartAt = 01.09.2025\r\n\tPerson = Person\r\n\t\tName = Slava\r\n\t\tAge = 33");
    }
}