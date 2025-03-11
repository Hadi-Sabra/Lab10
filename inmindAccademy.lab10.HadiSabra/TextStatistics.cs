namespace inmindAccademy.lab10.HadiSabra;

public static class TextStatistics
{
    public static int CountWords(string input)
    {
        return string.IsNullOrWhiteSpace(input) ? 0 : input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public static int CountCharacters(string input, bool excludeSpaces = false)
    {
        return excludeSpaces ? input.Replace(" ", "").Length : input.Length;
    }

    public static string MostCommonWord(string input)
    {
        var words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return words.GroupBy(w => w)
            .OrderByDescending(g => g.Count())
            .Select(g => g.Key)
            .FirstOrDefault() ?? string.Empty;
    }
}
