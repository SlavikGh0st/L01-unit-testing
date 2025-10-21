using System.Text;

namespace L02_serialization;

public static class Printer
{
    private static readonly HashSet<Type> FinalTypes = new()
    {
        typeof(string),
        typeof(int),
    };

    public static string PrintToString<T>(T? obj) => PrintToString(obj, 0);

    private static string PrintToString<T>(T? obj, int nestingLevel)
    {
        if (obj == null)
            return "null";

        var stringBuilder = new StringBuilder();

        var type = obj.GetType();
        if (FinalTypes.Contains(type))
            return obj.ToString()!;

        stringBuilder.AppendLine($"{type.Name}");
        var props = type.GetProperties();
        foreach (var prop in props)
        {
            var propIdent = new string('\t', nestingLevel + 1);
            var propName = prop.Name;
            var propValue = prop.GetValue(obj);
            var serializedPropValue = PrintToString(propValue, nestingLevel + 1);

            stringBuilder.AppendLine($"{propIdent}{propName} = {serializedPropValue}");
        }

        return stringBuilder.ToString().Trim();
    }
}