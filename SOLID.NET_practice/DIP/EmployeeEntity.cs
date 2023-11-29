using System.Text;

namespace SOLID.NET_practice.DIP;

public class EmployeeEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Salary { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        return sb.AppendLine("{")
            .AppendLine($"Id: {Id},")
            .AppendLine($"Name: {Name},")
            .AppendLine($"Surname: {Surname},")
            .AppendLine($"Salary: {Salary}")
            .AppendLine("}").ToString();
    }
}