using BetterConsoleTables;

namespace TaskMaster
{
    public class Queries(List<Task> _tasks)
    {
        private List<Task> Tasks = _tasks;

        public void ListTasks()
        {
            ForegroundColor = ConsoleColor.DarkBlue;
            WriteLine("-----LISTA DE TAREAS-----");
            Table table = new("ID", "Descripcion", "Estado")
            {
                Config = TableConfiguration.Unicode()
            };
            foreach (Task task in Tasks)
            {
                table.AddRow(task.Id, task.Description, task.Completed ? "Completada" : "");
            }
            WriteLine(table.ToString());
        }

        public List<Task> AddTask()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("-----Añadir Tarea-----");
                WriteLine("Ingrese la descripción de la tarea");
                string? descrption = ReadLine();
                Task task = new(Util.GenerateID(), descrption ?? string.Empty);
                Tasks.Add(task);
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Tarea añadida con exito");
                ResetColor();
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Error: {ex.Message}");
            }
            return Tasks;
        }

    }
}