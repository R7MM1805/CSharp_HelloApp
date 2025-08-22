using BetterConsoleTables;
using System.Threading.Tasks;

namespace TaskMaster
{
    public class Queries(List<Task> _tasks)
    {
        private readonly List<Task> Tasks = _tasks;

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
        public List<Task> MarkAsCompleted()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("-----Completar Tarea-----");
                WriteLine("Ingrese el id de la tarea");
                string? id = ReadLine();
                Task? task = Tasks.FirstOrDefault(x => x.Id == id);
                if (task is null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"No se encontró la tarea con el ID proporcionado: {id}");
                    ResetColor();
                    return Tasks;
                }
                task.Completed = true;
                task.ModifiedAt = DateTime.Now;
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Tarea completada con exito");
                ResetColor();
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Error: {ex.Message}");
            }
            return Tasks;
        }
        public List<Task> EditTask()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("-----Editar Tarea-----");
                WriteLine("Ingrese el id de la tarea");
                string? id = ReadLine();
                Task? task = Tasks.FirstOrDefault(x => x.Id == id);
                if (task is null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"No se encontró la tarea con el ID proporcionado: {id}");
                    ResetColor();
                    return Tasks;
                }
                WriteLine("Ingrese la descripción de la tarea");
                string? description = ReadLine();
                task.Description = description ?? string.Empty;
                task.ModifiedAt = DateTime.Now;
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Tarea editada con exito");
                ResetColor();
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Error: {ex.Message}");
            }
            return Tasks;
        }
        public List<Task> RemoveTask()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("-----Eliminar Tarea-----");
                WriteLine("Ingrese el id de la tarea");
                string? id = ReadLine();
                Task? task = Tasks.FirstOrDefault(x => x.Id == id);
                if (task is null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"No se encontró la tarea con el ID proporcionado: {id}");
                    ResetColor();
                    return Tasks;
                }
                Tasks.Remove(task);
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Tarea eliminada con exito");
                ResetColor();
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Error: {ex.Message}");
            }
            return Tasks;
        }
        public void TasksByState()
        {
            Clear();
            try
            {
                ResetColor();
                Clear();
                WriteLine("-----Filtrar Tarea-----");
                WriteLine("1. Completada");
                WriteLine("2. Pendiente");
                string? status = ReadLine();
                switch (status)
                {
                    case "1":
                        ShowTasksByStatus(true);
                        break;
                    case "2":
                        ShowTasksByStatus(false);
                        break;
                    default:
                        Clear();
                        WriteLine("Opción no válida. Intentar nuevamente");
                        break;
                }
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Ocurrió un error al filtrar las tareas: {ex.Message}");
            }
        }
        private void ShowTasksByStatus(bool isCompleted)
        {
            List<Task> tasks = [.. Tasks.Where(x => x.Completed == isCompleted)];
            if(tasks.Count == 0)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("No se encontraron tareas con el filtro solicitado");
                ResetColor();
            }
            else
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Lista de tareas");
                Table table = new("ID", "Descripcion", "Estado")
                {
                    Config = TableConfiguration.Unicode()
                };
                foreach (Task task in tasks)
                {
                    table.AddRow(task.Id, task.Description, task.Completed ? "Completada" : "");
                }
                WriteLine(table.ToString());
                ResetColor();
            }
        }
        public void TasksByDescription()
        {
            Clear();
            try
            {
                ResetColor();
                Clear();
                WriteLine("-----Filtrar Tarea por descripción-----");
                string? description = ReadLine();
                List<Task> tasks = Tasks.Where(x => x.Description?.Contains(description ?? string.Empty, StringComparison.OrdinalIgnoreCase) ?? false).ToList() ?? [];
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Lista de tareas");
                Table table = new("ID", "Descripcion", "Estado")
                {
                    Config = TableConfiguration.Unicode()
                };
                foreach (Task task in tasks)
                {
                    table.AddRow(task.Id, task.Description, task.Completed ? "Completada" : "");
                }
                WriteLine(table.ToString());
                ResetColor();
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Ocurrió un error al filtrar las tareas: {ex.Message}");
            }
        }
    }
}