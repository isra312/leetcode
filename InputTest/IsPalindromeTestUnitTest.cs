using Questions.Solutions;

namespace InputTest;

public class IsPalindromeTestUnitTest
{
    [Theory]
    [InlineData("A man, a plan, a canal: Panama")]
    [InlineData(" ")]
    public void IsPalindromeStringToLower_Should_Return_True(string input)
    {
        var result = ValidPalindrome.IsPalindromeStringToLower(input);

        Assert.True(result);
    }  
    
    [Theory]
    [InlineData("race a car")]
    public void IsPalindromeStringToLower_Should_Return_False(string input)
    {
        var result = ValidPalindrome.IsPalindromeStringToLower(input);

        Assert.False(result);
    }

    [Theory]
    [InlineData("A man, a plan, a canal: Panama")]
    [InlineData(" ")]
    public void IsPalindromeCharToLower_Should_Return_True(string input)
    {
        var result = ValidPalindrome.IsPalindromeCharToLower(input);

        Assert.True(result);
    }  
    
    [Theory]
    [InlineData("race a car")]
    public void IsPalindromeCharToLower_Should_Return_False(string input)
    {
        var result = ValidPalindrome.IsPalindromeCharToLower(input);

        Assert.False(result);
    }
}
