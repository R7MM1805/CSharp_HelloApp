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

    }
}