using TaskManagementApp.UseCase;
namespace TaskManagementTest;

public class HomeValidationTest
{
    [Theory]
    [InlineData("0", false)]
    [InlineData("1", true)]
    [InlineData("5", true)]
    [InlineData("6", false)]
    [InlineData("あ", false)]
    [InlineData("abc", false)] 
    [InlineData("", false)]
    public void Test1(string input, bool expected)
    {
        IHomeValidation homeValidation = new HomeValidation();
        Assert.Equal(expected, homeValidation.Validation(input));
    }
}