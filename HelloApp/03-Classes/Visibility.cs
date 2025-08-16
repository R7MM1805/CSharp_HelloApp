partial class Program
{
    public static void Visibility()
    {
        Jedi jedi = new()
        {
            PowerLevel = 5000,
            LightsaberColor = "Azul"
        };
        jedi.UseForce();
        WriteLine(jedi.PublicField);
        jedi.RevealSecrets();

        Sith sith = new();
        sith.ShowProtected();
    }
}
class Jedi
{
    public string PublicField = "Soy un Jedi y mi poder es conocido";
    private string PrivateField = "Mis pensamientos más profundos son privados";
    protected string ProtectedField = "El lado oscuro no debe conocer mis secretos";
    public int PowerLevel { get; set; }
    public string LightsaberColor { get; set; } = string.Empty;
    public void UseForce() => WriteLine($"Yo soy un Jedi con un sable de luz {LightsaberColor} y mi nivel de poder es {PowerLevel}");
    public void RevealSecrets() => WriteLine(PrivateField);
    private static void Meditate() => WriteLine($"Estoy en profunda meditación con la fuerza");
    protected static void Train() => WriteLine($"Estoy entrenando para convertirme en el mejor jedi");
}
class Sith: Jedi
{
    public void ShowProtected()
    {
        WriteLine(ProtectedField);
        Train();
    }
}