namespace SOLID.NET_practice.DIP;

public class MongoDataAccessor : IDataAccessor
{
    private readonly List<EmployeeEntity> _employees = new();
    
    public EmployeeEntity GetById(int Id)
    {
        return _employees.Find(x => x.Id == Id);
    }

    public int Add(EmployeeEntity emp)
    {
        emp.Id = _employees.Count + 1;
        _employees.Add(emp);

        return emp.Id;
    }

    public int Remove(EmployeeEntity emp)
    {
        _employees.Remove(emp);

        return emp.Id;
    }
}