using TaskManagementApp.UI;
using TaskManagementApp.Infrastructure;

//DB作成＆接続
IDBManager dbManager = new DbManager();
dbManager.Initialize();

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

dbManager.Close();