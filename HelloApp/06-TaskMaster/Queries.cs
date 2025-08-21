namespace TaskMaster
{
    public class Queries(List<Task> _tasks)
    {
        private List<Task> Tasks = _tasks;

        public void ListTasks()
        {
            ForegroundColor = ConsoleColor.DarkBlue;
            WriteLine("-----LISTA DE TAREAS-----");
            foreach (Task task in Tasks)
            {
                WriteLine("\n{0,-8}{1,-35}{2,-15}", "Id", "Descripcion", "Completado");
                WriteLine(new string('-', 58));
                WriteLine("\n{0,-8}{1,-35}{2,-15}", task.Id, task.Description, task.Completed);
            }
        }

    }
}