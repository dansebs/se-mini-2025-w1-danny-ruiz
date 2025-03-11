using Xunit;
public class StringCalculatorTests
{
    [Fact]
    public void Given_EmptyString_When_CalculatingSum_Then_returnZero()
    {
        //Given
        var calculator = new StringCalculator();
        //When
        int result = calculator.Add("");
        //Then
        Assert.Equal(0, result);
    }
    [Fact]
    public void Given_SingleNumber_When_CalculatingSum_Then_Return_That_Number()
    {
        //Given
        var calculator = new StringCalculator();
        //When 
        int result = calculator.Add("5");
        //Then
        Assert.Equal(5, result);
    }
    [Fact]
    public void Given_CommaDelimited_SUM()
    {
        //Given
        var calculator = new StringCalculator();
        //When
        int result = calculator.Add("5,5");
        //Then
        Assert.Equal(10, result);
    }
    [Fact]
    public void Given_newline_SUM()
    {
        //Given
        var calculator = new StringCalculator();
        //When
        int result = calculator.Add("10\n10");
        //Then
        Assert.Equal(20, result);
    }
    [Fact]
    public void Given_3_numbers_Any_Delimiter()
    {
        //Given
        var calculator = new StringCalculator();
        //When
        int result = calculator.Add("10,10\n10");
        //Then
        Assert.Equal(30, result);
    }
    [Fact]
    public void Given_negative_throw_exception()
    {
        //Given
        var calculator = new StringCalculator();
        //When
        //Then
        Assert.Throws<Exception>(() => calculator.Add("-100"));
    }
    [Fact]
    public void Given_num_greater_than_thousand()
    {
        //Given
        var calculator = new StringCalculator();
        //When
        int result = calculator.Add("1001,100,10");
        //Then
        Assert.Equal(110,result);
    }
}

