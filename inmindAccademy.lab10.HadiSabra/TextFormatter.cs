using System.Text;
using System.Text.RegularExpressions;

namespace inmindAccademy.lab10.HadiSabra;

public static class TextFormatter
{
    public static string ToSnakeCase(string input)
    {
        return Regex.Replace(input, @"([a-z])([A-Z])", "$1_$2").ToLower();
    }

    public static string ToKebabCase(string input)
    {
        return Regex.Replace(input, @"([a-z])([A-Z])", "$1-$2").ToLower();
    }

    public static string ToPascalCase(string input)
    {
        return Regex.Replace(input, @"(?:^|-|_)(\w)", m => m.Groups[1].Value.ToUpper());
    }

    public static string ToCamelCase(string input)
    {
        var pascal = ToPascalCase(input);
        return char.ToLower(pascal[0]) + pascal.Substring(1);
    }
}