using Eatable.Common.Exceptions;
using Eatable.Data.Mappers;
using Eatable.Data.Product;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Eatable.Data.Services
{
    public class ProductService: DBServices, IProductService
    {
        #region Store

        public List<Store> GetStoreList()
        {
            var result = new List<Store>();
            var strSql = new StringBuilder();

            strSql.Append(@"SELECT
                        s.StoreId,
                        s.StoreIdentifier,
                        s.StoreName,
                        s.StoreUrl,
                        s.StoreTypeCode,
                        s.LogoName,
                        s.OpeningHoursJson
                        FROM [dbo].[Store] s");

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
                       result.Add(ProductMapper.MapStoreOut(reader));                    
                    }
                }
            }
            return result;
        }

        public Store GetStoreById(Guid id)
        {
            var result = new Store();

            var strSql = new StringBuilder();
            strSql.Append(@"SELECT
                        s.StoreId,
                        s.StoreIdentifier,
                        s.StoreName,
                        s.StoreUrl,
                        s.StoreTypeCode,
                        s.LogoName,
                        s.OpeningHoursJson,
                        a.AddressId,
                        a.CityName,
                        a.CountryCode,
                        a.StreetName,
                        a.HouseNumber,
                        a.BoxNumber,
                        a.PostalCode,
                        c.ContactId,
                        c.ContactInfo,
                        c.ContactTypeCode
                        FROM [dbo].[Store] s
                        INNER JOIN [dbo].[Address] a ON a.AddressId = s.StoreAddressId
                        INNER JOIN [dbo].[ContactInformation] c ON c.ContactId = s.StoreContactInformationId
                        where s.StoreId = @StoreId"
                        );
            using (var connection = new SqlConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = strSql.ToString();
                command.Parameters.Add(new SqlParameter
                {
                    SqlDbType = System.Data.SqlDbType.UniqueIdentifier,
                    ParameterName = "@StoreId",
                    Value = id
                });

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result = ProductMapper.MapStoreFullOut(reader);
                    }
                }
            }

            if (result == null)
                throw new BusinessException("Failed to get");

            return result;
        }

        public Store GetStoreByIdentifier(string identifier)
        {
            var result = new Store();

            var strSql = new StringBuilder();
            strSql.Append(@"SELECT
                        s.StoreId,
                        s.StoreIdentifier,
                        s.StoreName,
                        s.StoreUrl,
                        s.StoreTypeCode,
                        s.LogoName,
                        s.OpeningHoursJson,
                        a.AddressId,
                        a.CityName,
                        a.CountryCode,
                        a.StreetName,
                        a.HouseNumber,
                        a.BoxNumber,
                        a.PostalCode,
                        c.ContactId,
                        c.ContactInfo,
                        c.ContactTypeCode
                        FROM [dbo].[Store] s
                        INNER JOIN [dbo].[Address] a ON a.AddressId = s.StoreAddressId
                        INNER JOIN [dbo].[ContactInformation] c ON c.ContactId = s.StoreContactInformationId
                        where s.StoreIdentifier = @StoreIdentifier"
                        );
            using (var connection = new SqlConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = strSql.ToString();
                command.Parameters.Add(new SqlParameter
                {
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                    ParameterName = "@StoreIdentifier",
                    Value = identifier
                });

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result = ProductMapper.MapStoreFullOut(reader);
                    }
                }
            }

            if (result == null)
                throw new BusinessException("Failed to get");

            return result;
        }

        #endregion Store
    }
}
