namespace SOLID.NET_practice.DIP;

public class DataAccessFactory
{
    public static IDataAccessor GetMongoEmployeeDataAccessObj()
    {
        return new MongoDataAccessor();
    }
    
    public static IDataAccessor GetPostgresEmployeeDataAccessObj()
    {
        return new PostgresDataAccessor();
    }
}