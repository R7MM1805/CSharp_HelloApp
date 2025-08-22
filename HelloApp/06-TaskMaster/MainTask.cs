using TaskMaster;

partial class Program
{
    static readonly FileActions<TaskMaster.Task> fileActions = new("../../../06-TaskMaster/Tasks.json");
    static readonly List<TaskMaster.Task> tasks = fileActions.ReadFile();
    static readonly Queries queries = new(tasks);
    public static void TaskMaster()
    {
        bool exit = false;
        while (!exit)
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine("------Menú de tareas------");
            WriteLine("\n1. Listar tareas");
            WriteLine("2. Añadir tarea");
            WriteLine("3. Marcar tarea como completada");
            WriteLine("4. Editar tarea");
            WriteLine("5. Eliminar tarea");
            WriteLine("6. Consultar tareas por estado");
            WriteLine("7. Consultar tarea por descripción");
            WriteLine("8. Salir");
            Write("\nSeleccione una opción: ");
            switch (ReadLine())
            {
                case "1":
                    queries.ListTasks();
                    break;
                case "2":
                    AddTask();
                    break;
                case "3":
                    MarkAsCompleted();
                    break;
                case "4":
                    EditTask();
                    break;
                case "5":
                    RemoveTask();
                    break;
                case "6":
                    queries.TasksByState();
                    break;
                case "8":
                    exit = true; 
                    Clear();
                    break;
                default:
                    Clear(); 
                    WriteLine("Opción no válida. Intentar nuevamente");
                    break;
            }
                //"7" => TasksByDescription(),
        }
    }
    public static void AddTask()
    {
        try
        {
            List<TaskMaster.Task> tasks = queries.AddTask();
            fileActions.WriteFile(tasks);
        }
        catch (Exception ex)
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine($"Ocurrió un error al agregar la tarea: {ex.Message}");
        }
    }
    public static void MarkAsCompleted()
    {
        try
        {
            List<TaskMaster.Task> tasks = queries.MarkAsCompleted();
            fileActions.WriteFile(tasks);
        }
        catch (Exception ex)
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine($"Ocurrió un error al completar la tarea: {ex.Message}");
        }
    }
    public static void EditTask()
    {
        try
        {
            List<TaskMaster.Task> tasks = queries.EditTask();
            fileActions.WriteFile(tasks);
        }
        catch (Exception ex)
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine($"Ocurrió un error al editar la tarea: {ex.Message}");
        }
    }
    public static void RemoveTask()
    {
        try
        {
            List<TaskMaster.Task> tasks = queries.RemoveTask();
            fileActions.WriteFile(tasks);
        }
        catch (Exception ex)
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine($"Ocurrió un error al eliminar la tarea: {ex.Message}");
        }
    }
}