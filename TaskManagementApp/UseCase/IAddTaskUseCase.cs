using TaskManagementApp.Domain.Model;

namespace TaskManagementApp.UseCase;

public interface IAddTaskUseCase
{
    void AddTask(string name, string date);
}