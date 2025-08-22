using BetterConsoleTables;
using HelloApp.Util;

namespace TaskMaster
{
    public class Queries(List<Task> _tasks)
    {
        private readonly List<Task> Tasks = _tasks;

        #region Public Methods
        public void ListTasks()
        {
            ForegroundColor = ConsoleColor.DarkBlue;
            WriteLine("-----LISTA DE TAREAS-----");
            WriteLine(ConfigureTaskTable(Tasks));
        }
        public List<Task> AddTask()
        {
            try
            {
                InitConsole("-----Añadir Tarea-----", "Ingrese la descripción de la tarea");
                string? descrption = ReadLine();
                string validate = Validation.ValidateString(descrption, "Se requiere la descripción de la tarea");
                return string.IsNullOrEmpty(validate) ? RegisterTaks(descrption!) : SetError(ConsoleColor.Red, validate);
            }
            catch (Exception ex)
            {
                Util.SetMessage(ConsoleColor.Red, $"Error: {ex.Message}");
                return Tasks;
            }
        }
        public List<Task> MarkAsCompleted()
        {
            try
            {
                InitConsole("-----Completar Tarea-----", "Ingrese el id de la tarea");
                string? id = ReadLine();
                string validate = ValidateTasksID(id);
                return string.IsNullOrEmpty(validate) ? CompletedTasks(id!) : SetError(ConsoleColor.Red, validate);
            }
            catch (Exception ex)
            {
                Util.SetMessage(ConsoleColor.Red, $"Error: {ex.Message}");
                return Tasks;
            }
        }
        public List<Task> EditTask()
        {
            try
            {
                InitConsole("-----Editar Tarea-----", "Ingrese el id de la tarea");
                string? id = ReadLine();
                string validate = ValidateTasksID(id);
                return string.IsNullOrEmpty(validate) ? UpdateTasks(id!) : SetError(ConsoleColor.Red, validate);
            }
            catch (Exception ex)
            {
                Util.SetMessage(ConsoleColor.Red, $"Error: {ex.Message}");
                return Tasks;
            }
        }
        public List<Task> RemoveTask()
        {
            try
            {
                InitConsole("-----Eliminar Tarea-----", "Ingrese el id de la tarea");
                string? id = ReadLine();
                string validate = ValidateTasksID(id);
                return string.IsNullOrEmpty(validate) ? RemoveTaskByID(id!) : SetError(ConsoleColor.Red, validate);
            }
            catch (Exception ex)
            {
                Util.SetMessage(ConsoleColor.Red, $"Error: {ex.Message}");
                return Tasks;
            }
        }
        public void TasksByState()
        {
            try
            {
                InitConsole("-----Filtrar Tarea-----", "Seleccione el estado. \n1. Completada \n2. Pendiente");
                FindTasksByStatus(ReadLine());
            }
            catch (Exception ex)
            {
                Util.SetMessage(ConsoleColor.Red, $"Ocurrió un error al filtrar las tareas: {ex.Message}");
            }
        }
        public void TasksByDescription()
        {
            try
            {
                InitConsole("-----Filtrar Tarea por descripción-----", "");
                string description = ReadLine() ?? string.Empty;
                List<Task> tasks = Tasks.Where(x => x.Description.Contains(description, StringComparison.OrdinalIgnoreCase)).ToList() ?? [];
                if (tasks.Count == 0) Util.SetMessage(ConsoleColor.Red, "No se encontraron tareas con el filtro solicitado");
                else WriteLine(ConfigureTaskTable(tasks));
            }
            catch (Exception ex)
            {
                Util.SetMessage(ConsoleColor.Red, $"Ocurrió un error al filtrar las tareas: {ex.Message}");
            }
        }
        #endregion

        #region Private Methods

        #region ListTasks
        private static string ConfigureTaskTable(List<Task> tasks)
        {
            tasks = [.. tasks.Where(x => !x.Deleted)];
            Table table = new("ID", "Descripcion", "Estado")
            {
                Config = TableConfiguration.Unicode()
            };
            tasks.ForEach(x => table.AddRow(x.Id, x.Description, x.Completed ? "Completada" : ""));
            return table.ToString();
        }
        #endregion

        #region AddTask
        private static void InitConsole(string title, string subtitle)
        {
            ResetColor();
            Clear();
            WriteLine(title);
            WriteLine(subtitle);
        }
        private List<Task> RegisterTaks(string description)
        {
            Task task = new(Util.GenerateID(), description);
            Tasks.Add(task);
            Util.SetMessage(ConsoleColor.Green, "Tarea añadida con éxito");
            return Tasks;
        }
        private List<Task> SetError(ConsoleColor color, string message)
        {
            Util.SetMessage(color, message);
            return Tasks;
        }
        #endregion

        #region MarkAsCompleted
        private string ValidateTasksID(string? id)
        {
            string response = Validation.ValidateString(id, "Se requiere el id de la tarea");
            if (!string.IsNullOrEmpty(response)) return response;
            Task? task = GetTaskByID(id!);
            return task is null ? $"No se encontró la tarea con el ID proporcionado: {id}" : string.Empty;
        }
        private Task? GetTaskByID(string id) => Tasks.FirstOrDefault(x => x.Id == id);
        private List<Task> CompletedTasks(string id)
        {
            Task? task = GetTaskByID(id);
            if (task is null) return [];
            task.Completed = true;
            task.ModifiedAt = DateTime.Now;
            Util.SetMessage(ConsoleColor.Green, "Tarea completada con exito");
            return Tasks;
        }
        #endregion

        #region EditTask
        private List<Task> UpdateTasks(string id)
        {
            Task? task = GetTaskByID(id);
            if (task is null) return [];
            WriteLine("Ingrese la descripción de la tarea");
            string? description = ReadLine();
            string validate = Validation.ValidateString(description, "Se requiere la descripción de la tarea");
            return string.IsNullOrEmpty(validate) ? ModifyTasks(task, description!) : SetError(ConsoleColor.Red, validate);
        }
        private List<Task> ModifyTasks(Task task, string description)
        {
            task.Description = description;
            task.ModifiedAt = DateTime.Now;
            Util.SetMessage(ConsoleColor.Green, "Tarea modificada con éxito");
            return Tasks;
        }
        #endregion

        #region RemoveTask
        private List<Task> RemoveTaskByID(string id)
        {
            Task? task = GetTaskByID(id);
            if (task is null) return [];
            task.Deleted = true;
            task.ModifiedAt = DateTime.Now;
            Util.SetMessage(ConsoleColor.Green, "Tarea eliminada con éxito");
            return Tasks;
        }
        #endregion

        #region TasksByState
        private void FindTasksByStatus(string? status)
        {
            switch (status)
            {
                case "1":
                    ShowTasksByStatus(true);
                    break;
                case "2":
                    ShowTasksByStatus(false);
                    break;
                default:
                    WriteLine("Opción no válida. Intentar nuevamente");
                    TasksByState();
                    break;
            }
        }
        private void ShowTasksByStatus(bool isCompleted)
        {
            List<Task> tasks = [.. Tasks.Where(x => x.Completed == isCompleted)];
            if (tasks.Count == 0) Util.SetMessage(ConsoleColor.Red, "No se encontraron tareas con el filtro solicitado");
            else WriteLine(ConfigureTaskTable(tasks));
        }
        #endregion

        #endregion
    }
}