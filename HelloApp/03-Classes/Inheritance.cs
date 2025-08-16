partial class Program
{
    public static void Inheritance()
    {
        HogartsStudent student = new()
        {
            Name = "Harry Potter",
            House = "Gryffindor"
        };
        HogartsProfessor professor = new()
        {
            Name = "Serverus Snape",
            Subject = "Pociones"
        };
        student.Greet();
        student.ShowHouse();
        professor.Greet();
        professor.MySubject();
    }
}
class Character
{
    public string Name { get; set; } = string.Empty;
    public virtual void Greet() => WriteLine($"Hola, soy {Name}");
}
class HogartsStudent : Character
{
    public string House { get; set; } = string.Empty;
    public void ShowHouse() => WriteLine($"Pertenezco a la casa {House} en Hogarts");
    public override void Greet() => WriteLine($"Hola, soy {Name} y soy estudiante");
}
class HogartsProfessor : Character
{
    public string Subject { get; set; } = string.Empty;
    public void MySubject() => WriteLine($"Enseño {Subject} en Hogarts");
    public override void Greet() => WriteLine($"Hola, soy {Name} y soy profesor");
}