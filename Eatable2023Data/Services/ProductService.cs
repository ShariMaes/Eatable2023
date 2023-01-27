using Eatable.Data.Product;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Eatable.Data.Services
{
    public class ProductService: DBServices, IProductService
    {
        public List<Store> GetStoreList()
        {
            var result = new List<Store>();
            var strSql = new StringBuilder();

            strSql.Append(@"SELECT Name FROM dbo.Store");

            using (var connection = new SqlConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = strSql.ToString();
                command.Parameters.Clear();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var store = new Store
                        {
                            StoreName = reader.GetString(0),

                        };
                        result.Add(store);
                    }
                }
            }
            return result;
        }
    
    }
}
