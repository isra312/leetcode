using Questions.Questions;

namespace InputTest;

public class ValidParenthesisUnitTest
{
    [Theory()]
    [InlineData("[{}]")]
    [InlineData("()[]{}")]
    public void IsValidDictionary_Should_Return_True(string input)
    {
        bool isValid = ValidParenthesis.IsValidDictionary(input);

        Assert.True(isValid);
    }

    [Theory()]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("ssds")]
    [InlineData("a[dsds]")]
    [InlineData("{[}]")]
    [InlineData("     ")]
    [InlineData("( [ ) ]")]
    [InlineData("((")]
    [InlineData("){")]
    public void IsValidDictionary_Should_Return_False(string input)
    {
        bool isValid = ValidParenthesis.IsValidDictionary(input);

        Assert.False(isValid);
    }

    [Theory()]
    [InlineData("[{}]")]
    [InlineData("()[]{}")]
    public void IsValidSimpleLoop_Should_Return_True(string input)
    {
        bool isValid = ValidParenthesis.IsValidSimpleLoop(input);

        Assert.True(isValid);
    }

    [Theory()]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("ssds")]
    [InlineData("a[dsds]")]
    [InlineData("{[}]")]
    [InlineData("     ")]
    [InlineData("( [ ) ]")]
    [InlineData("((")]
    [InlineData("){")]
    public void IsValidSimpleLoop_Should_Return_False(string input)
    {
        bool isValid = ValidParenthesis.IsValidSimpleLoop(input);

        Assert.False(isValid);
    }

    [Theory()]
    [InlineData("[{}]")]
    [InlineData("()[]{}")]
    public void IsValidNestedIfs_Should_Return_True(string input)
    {
        bool isValid = ValidParenthesis.IsValidNestedIfs(input);

        Assert.True(isValid);
    }

    [Theory()]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("ssds")]
    [InlineData("a[dsds]")]
    [InlineData("{[}]")]
    [InlineData("     ")]
    [InlineData("( [ ) ]")]
    [InlineData("((")]
    [InlineData("){")]
    public void IsValidNestedIfs_Should_Return_False(string input)
    {
        bool isValid = ValidParenthesis.IsValidNestedIfs(input);

        Assert.False(isValid);
    }

}