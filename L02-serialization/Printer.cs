using System.Text;

namespace L02_serialization;

public static class Printer
{
    public static string PrintToString<T>(T? obj)
    {
        if (obj == null)
            return "null" + Environment.NewLine;

        var type = obj.GetType();
        var stringBuilder = new StringBuilder(type.Name).AppendLine();
        
        var properties = type.GetProperties();
        foreach (var prop in properties)
        {
            stringBuilder.Append($"\t{prop.Name} = {prop.GetValue(obj)}").AppendLine();
        }

        return stringBuilder.ToString().Trim();
    }
}