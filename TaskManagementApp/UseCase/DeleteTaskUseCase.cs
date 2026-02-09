using TaskManagementApp.Infrastructure.Repository;
namespace TaskManagementApp.UseCase;

public class DeleteTaskUseCase
{
    private readonly ITaskDeleteRepository _taskDeleteRepository = new TaskDeleteRepository();
    public void DeleteTask(int id)
    {
        _taskDeleteRepository.DeleteTask(id);
    }
}
