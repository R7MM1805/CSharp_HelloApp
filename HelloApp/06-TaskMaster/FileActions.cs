using System.Text.Encodings.Web;
using System.Text.Json;

namespace TaskMaster
{
    public class FileActions<T>(string name)
    {
        private readonly string filePath = name;

        private readonly JsonSerializerOptions _optionsWrite =
          new() { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };

        private readonly JsonSerializerOptions _optionsRead =
          new() { PropertyNameCaseInsensitive = true };

        public void WriteFile(List<T> data)
        {
            try
            {
                string content = JsonSerializer.Serialize(data, _optionsWrite);

                StreamWriter sw = new(filePath);
                sw.Write(content);
                sw.Dispose();

                ForegroundColor = ConsoleColor.Green;
                WriteLine("¡Cambios guardados con exito!");
                ResetColor();
            }
            catch (IOException ex)
            {
                WriteLine($"Error al leer el archivo: {ex.Message}");
            }
            catch (Exception ex)
            {
                WriteLine($"Ocurrió un error al escribir en el archivo: {ex.Message}");
            }
        }

        public List<T> ReadFile()
        {
            try
            {
                StreamReader sr = new(filePath);
                string rawData = sr.ReadToEnd();
                List<T> data = JsonSerializer.Deserialize<List<T>>(rawData, _optionsRead)!;
                sr.Dispose();
                return data;
            }
            catch (IOException ex)
            {
                WriteLine($"Error de E/S al leer el archivo: {ex.Message}");
                return [];
            }
            catch (Exception ex)
            {
                WriteLine($"Ocurrió un error al leer el archivo: {ex.Message}");
                return [];
            }
        }
    }
}