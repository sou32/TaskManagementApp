using TaskManagementApp.UI;
using TaskManagementApp.Infrastructure;

// DB作成＆接続
IDBInitializer dbInitializer = new DBInitializer();
dbInitializer.Initialize();

while (true)
{
    IHomeUI homeUi = new HomeUI();
    TaskViewUI taskViewUi = new TaskViewUI();
    AddTaskUI addTaskUi = new AddTaskUI();
    DeleteTaskUI deleteTaskUi = new DeleteTaskUI();
    
    int command = homeUi.ShowStartMessage();
    
    // コマンドによって処理を分岐
    if (command == 1)
    {
        taskViewUi.ShowTaskList();
    }
    else if (command == 2)
    {
        addTaskUi.AddTask();
    }
    else if (command == 3)
    {
        deleteTaskUi.DeleteTask();
    }
    else
    {
        break;
    }
}