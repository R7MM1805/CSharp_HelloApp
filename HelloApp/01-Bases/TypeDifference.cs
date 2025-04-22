namespace HelloApp._01_Bases
{
    partial class Program
    {
        public static void TypeDifference()
        {
            int x = 5;
            int y = x;
            y = 15;
            Console.WriteLine($"""
                x: {x},
                y: {y}
                """);

            Person person1 = new() { Name = "Ricardo" };
            Person person2 = person1;
            person2.Name = "Rosa";
            Console.WriteLine($"""
                person1: {person1.Name},
                person2: {person2.Name}
                """);
        }
    }
}

class Person
{
    public string Name { get; set; } = string.Empty;
}