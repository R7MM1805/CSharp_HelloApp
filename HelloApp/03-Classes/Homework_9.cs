partial class Program
{
    public static void EmployeeSalary()
    {
        List<Employee> employees =
        [
            new TeamLeader("Carlos", 5000),
            new Developer("Ana", 4000),
            new TeamLeader("Laura", 6000),
            new Developer("Luis", 3500)
        ];
        WriteLine("Lista de empleados");
        employees.ForEach(x => x.ShowInformation());
    }
}
class Employee(string name, decimal salary, string position)
{
    protected string Name { get; set; } = name;
    protected decimal Salary { get; set; } = salary;
    protected string Position { get; set; } = position;

    public virtual decimal CalculateBonus() => Salary * 0.05m;
    public void ShowInformation() => WriteLine($"Nombre: {Name}, Cargo: {Position}, Salario: {Salary:C}, Bono Calculado: {CalculateBonus():C}");
}
class TeamLeader(string name, decimal salary) : Employee(name, salary, "Team Leader")
{
    public override decimal CalculateBonus() => Salary * 0.10m;
}
class Developer(string name, decimal salary) : Employee(name, salary, "Developer")
{
    public override decimal CalculateBonus() => Salary * 0.07m;
}