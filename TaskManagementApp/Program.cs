using TaskManagementApp.UI;
while (true)
{
    IHome home = new Home();
    TaskView taskView = new TaskView();
    
    int command = home.ShowStartMessage();
    
    
    // コマンドによって処理を分岐
    switch (command)
    {
        case 1:
            taskView.ShowTaskList();
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;
    }
}