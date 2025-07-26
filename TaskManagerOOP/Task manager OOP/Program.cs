using Task_manager_OOP;

internal class Program
{
    private static void Main(string[] args)
    {
        TaskManager taskManager = new TaskManager();
        taskManager.LoadTasksFromFileSafe();
        taskManager.ShowMenu();
    }
}