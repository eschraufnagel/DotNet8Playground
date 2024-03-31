using DotNet8Playground.Services;

namespace DotNet8Playground.UnitTests;

public class ReverseStringTests
{
    private readonly IStringService _stringService = new StringService();

    [Fact]
    public void ReverseString_InputEmptyString_ReturnsEmptyString()
    {
        // Arrange
        var input = string.Empty;
        var expected = string.Empty;

        // Act
        var actual = _stringService.ReverseString(input);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ReverseString_InputSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        var input = "a";
        var expected = "a";

        // Act
        var actual = _stringService.ReverseString(input);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ReverseString_InputNonEmptyString_ReturnsReversedString()
    {
        // Arrange
        var input = "Hello, world!";
        var expected = "!dlrow ,olleH";

        // Act
        var actual = _stringService.ReverseString(input);

        // Assert
        Assert.Equal(expected, actual);
    }
}