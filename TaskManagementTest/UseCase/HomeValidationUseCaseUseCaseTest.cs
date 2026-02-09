using TaskManagementApp.UseCase;
namespace TaskManagementTest.UseCase;

public class HomeValidationUseCaseUseCaseTest
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
        IHomeValidationUseCase homeValidationUseCase = new HomeValidationUseCaseUseCase();
        Assert.Equal(expected, homeValidationUseCase.Validation(input));
    }
}