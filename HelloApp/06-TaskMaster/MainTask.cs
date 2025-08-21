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
                case "8":
                    exit = true; 
                    Clear();
                    break;
                default:
                    Clear(); 
                    WriteLine("Opción no válida. Intentar nuevamente");
                    break;
            }
                //"2" => AddTask(),
                //"3" => MarkAsCompleted(),
                //"4" => EditTask(),
                //"5" => RemoveTask(),
                //"6" => TasksByState(),
                //"7" => TasksByDescription(),
        }
    }
}