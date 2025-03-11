using Xunit;
using FluentAssertions;
using inmindAccademy.lab10.HadiSabra;

namespace inmindAccademy.Lab10.HadiSabra.Tests;

public class TextFormatterTests
{
    [Theory]
    [InlineData("HelloWorld", "hello_world")]
    [InlineData("SnakeCase", "snake_case")]
    public void ToSnakeCase_ShouldConvertToSnakeCase(string input, string expected)
    {
        var result = TextFormatter.ToSnakeCase(input);
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData("HelloWorld", "hello-world")]
    [InlineData("KebabCase", "kebab-case")]
    public void ToKebabCase_ShouldConvertToKebabCase(string input, string expected)
    {
        var result = TextFormatter.ToKebabCase(input);
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData("hello_world", "HelloWorld")]
    [InlineData("kebab-case", "KebabCase")]
    public void ToPascalCase_ShouldConvertToPascalCase(string input, string expected)
    {
        var result = TextFormatter.ToPascalCase(input);
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData("hello_world", "helloWorld")]
    [InlineData("kebab-case", "kebabCase")]
    public void ToCamelCase_ShouldConvertToCamelCase(string input, string expected)
    {
        var result = TextFormatter.ToCamelCase(input);
        result.Should().Be(expected);
    }
}