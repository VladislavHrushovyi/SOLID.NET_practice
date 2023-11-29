namespace SOLID.NET_practice.DIP;

public interface IDataAccessor
{
    public EmployeeEntity GetById(int Id);
    public int Add(EmployeeEntity emp);
    public int Remove(EmployeeEntity emp);
}