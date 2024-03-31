using System.Text;

namespace DotNet8Playground.Services;

public class StringService : IStringService
{
    public string ReverseString(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return string.Empty;
        }
    
        var output = new StringBuilder();

        for (var i = input.Length - 1; i >= 0; i--)
        {
            output.Append(input[i]);
        }

        return output.ToString();
    }
}