using TaskManagementApp.UI;
using TaskManagementApp.Infrastructure;

// DB作成＆接続
IDBInitializer dbInitializer = new DBInitializer();
dbInitializer.Initialize();

while (true)
{
    IHome home = new Home();
    TaskView taskView = new TaskView();
    
    int command = home.ShowStartMessage();
    
    // コマンドによって処理を分岐
    if (command == 1)
    {
        taskView.ShowTaskList();
    }
    else
    {
        break;
    }
}