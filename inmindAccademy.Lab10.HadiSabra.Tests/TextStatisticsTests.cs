using Xunit;
using FluentAssertions;
using inmindAccademy.lab10.HadiSabra;

namespace inmindAccademy.Lab10.HadiSabra.Tests;

public class TextStatisticsTests
{
    [Theory]
    [InlineData("Hello world!", 2)]
    [InlineData("This is a test.", 4)]
    [InlineData("", 0)]
    public void CountWords_ShouldReturnCorrectWordCount(string input, int expected)
    {
        var result = TextStatistics.CountWords(input);
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData("Hello", 5)]
    [InlineData("Hello world", 11)]
    [InlineData("Hello world", 10, true)]
    public void CountCharacters_ShouldReturnCorrectCharacterCount(string input, int expected, bool excludeSpaces = false)
    {
        var result = TextStatistics.CountCharacters(input, excludeSpaces);
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData("apple banana apple", "apple")]
    [InlineData("this is is a test", "is")]
    public void MostCommonWord_ShouldReturnMostFrequentWord(string input, string expected)
    {
        var result = TextStatistics.MostCommonWord(input);
        result.Should().Be(expected);
    }
}