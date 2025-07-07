namespace HelloApp._01_Bases
{
    partial class Program
    {
        public static void ListDictionary()
        {
            List<string> names = ["Ricardo", "Rosa", "Alvaro"];
            names.Add("Violeta");
            names.Add("Maritza");
            WriteLine($"Total de nombres: {names.Count}");
            foreach (string name in names)
            {
                WriteLine($"Nombre: {name}");
            }
            names.Remove("Maritza");
            bool isPresent = names.Contains("Maritza");
            WriteLine($"Maritza está en la lista? {isPresent}");

            /*Dictionary*/
            Dictionary<int, string> students = new()
            {
                { 1, "Ricardo" },
                { 2, "Martin" },
                { 3, "Alvaro" },
                { 4, "Fabrizzio" },
                { 5, "Rosa" },
                { 6, "Maria" }
            };
            foreach (KeyValuePair<int, string> student in students)
            {
                WriteLine($"Estudiante: {student}. Key: {student.Key}. Value: {student.Value}");
            }
        }
    }
}