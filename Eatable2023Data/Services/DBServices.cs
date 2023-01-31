namespace Eatable.Data.Services
{
    public class DBServices : IDBServices
    {
        public readonly string _connectionString;

        public DBServices()
        {
            _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EatableV1.0;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
    }
}
