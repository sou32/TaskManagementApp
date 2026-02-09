using System.Globalization;
using TaskManagementApp.UseCase;
namespace TaskManagementTest.UseCase;

public class AddTaskValidationUseCaseTest
{
    [Theory]
    [InlineData("Task1", "2026-03-29", true)]
    [InlineData("このタスクは30文字を超えています。もう少し短い30文字以下のタスク名を入力してください。お願いします", "2026-05-23", false)]
    [InlineData("Task2", "2025-03-29", false)]

    public void Test1(string input, string dateOnly, bool expected)
    {
        IAddTaskValidationUseCase addTaskValidationUseCase = new AddTaskValidationUseCase();
        Assert.Equal(expected, addTaskValidationUseCase.Validate(input,dateOnly));
    }
}