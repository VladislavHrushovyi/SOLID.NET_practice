using SOLID.NET_practice.S;

namespace SOLID.NET_practice.DIP;

public class EmployeeBusinessLogic(IDataAccessor dataAccessor)
{
    private readonly ILogger _logger = new ConsoleLogger();
    
    public EmployeeEntity GetEmployeeDetails(int id)
    {
        var emp = dataAccessor.GetById(id);
        _logger.Log($"Employee details employee={emp}", LoggingType.Info);
        return emp;
    }

    public void CreateEmployee(EmployeeEntity emp)
    {
        var empId = dataAccessor.Add(emp);
        
        _logger.Log($"Employee was added with id={empId}", LoggingType.Info);
    }
    
    public void RemoveEmployee(EmployeeEntity emp)
    {
        var empId = dataAccessor.Remove(emp);
        
        _logger.Log($"Employee was removed with id={empId}", LoggingType.Info);
    }
}