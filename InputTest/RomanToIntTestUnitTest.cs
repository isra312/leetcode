using Questions.Questions;

namespace InputTest;

public class RomanToIntTestUnitTest
{
    [Fact]
    public void I_Should_Return_1()
    {
        var integer = RomanToInteger.RomanToInt("I");

        Assert.Equal(1, integer);
    }

    [Fact]
    public void V_Should_Return_5()
    {
        var integer = RomanToInteger.RomanToInt("V");

        Assert.Equal(5, integer);
    }

    [Fact]
    public void X_Should_Return_10()
    {
        var integer = RomanToInteger.RomanToInt("X");

        Assert.Equal(10, integer);
    }

    [Fact]
    public void L_Should_Return_50()
    {
        var integer = RomanToInteger.RomanToInt("L");

        Assert.Equal(50, integer);
    }

    [Fact]
    public void XX_Should_Return_20()
    {
        var integer = RomanToInteger.RomanToInt("XX");

        Assert.Equal(20, integer);
    }

    [Fact]
    public void XL_Should_Return_40()
    {
        var integer = RomanToInteger.RomanToInt("XL");

        Assert.Equal(40, integer);
    }

    [Fact]
    public void MCMLXXXIX_Should_Return_1989()
    {
        var integer = RomanToInteger.RomanToInt("MCMLXXXIX");

        Assert.Equal(1989, integer);
    }

    [Fact]
    public void DCCXCIII_Should_Return_793()
    {
        var integer = RomanToInteger.RomanToInt("DCCXCIII");

        Assert.Equal(793, integer);
    }

    [Fact]
    public void CCCLXXXV_Should_Return_385()
    {
        var integer = RomanToInteger.RomanToInt("CCCLXXXV");

        Assert.Equal(385, integer);
    }

    [Fact]
    public void MMMCMXCIX_Should_Return_385()
    {
        var integer = RomanToInteger.RomanToInt("MMMCMXCIX");

        Assert.Equal(3999, integer);
    }
}
