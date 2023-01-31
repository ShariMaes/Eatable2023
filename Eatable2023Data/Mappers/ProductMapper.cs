using Eatable.Data.Product;
using System.Data;

namespace Eatable.Data.Mappers
{
    public static class ProductMapper
    {
        public static Store MapStoreOut(IDataRecord record)
        {
            int ordinalId = record.GetOrdinal("StoreId");
            int ordinalIdentifier = record.GetOrdinal("StoreIdentifier");
            int ordinalName = record.GetOrdinal("StoreName");
            int ordinalUrl = record.GetOrdinal("StoreUrl");
            int ordinalTypeCode = record.GetOrdinal("StoreTypeCode");
            int ordinalLogo = record.GetOrdinal("LogoName");
            int ordinalHours = record.GetOrdinal("OpeningHoursJson");

            var temp = new Store();
            temp.StoreId = record.GetGuid(ordinalId);
            temp.StoreIdentifier = record.IsDBNull(ordinalIdentifier) ? null : record.GetString(ordinalIdentifier);
            temp.StoreName = record.IsDBNull(ordinalName) ? null : record.GetString(ordinalName);
            temp.StoreUrl = record.IsDBNull(ordinalUrl) ? null : record.GetString(ordinalUrl); ;
            temp.StoreType = (Common.Enums.StoreType)record.GetInt32(ordinalTypeCode);
            temp.LogoName = record.IsDBNull(ordinalLogo) ? null : record.GetString(ordinalLogo);
            temp.OpeningHours = record.IsDBNull(ordinalHours) ? null : record.GetString(ordinalHours);            

            return temp;
        }

        public static Store MapStoreFullOut(IDataRecord record)
        {
            int ordinalId = record.GetOrdinal("StoreId");
            int ordinalIdentifier = record.GetOrdinal("StoreIdentifier");
            int ordinalName = record.GetOrdinal("StoreName");
            int ordinalUrl = record.GetOrdinal("StoreUrl");
            int ordinalTypeCode = record.GetOrdinal("StoreTypeCode");
            int ordinalLogo = record.GetOrdinal("LogoName");
            int ordinalHours = record.GetOrdinal("OpeningHoursJson");
            //Address
            int ordinalAddressId = record.GetOrdinal("AddressId");
            int ordinalCity = record.GetOrdinal("CityName");
            int ordinalCountry = record.GetOrdinal("CountryCode");
            int ordinalStreet = record.GetOrdinal("StreetName");
            int ordinalHouseNumber = record.GetOrdinal("HouseNumber");
            int ordinalBoxNumber = record.GetOrdinal("BoxNumber");
            int ordinalPostalCode = record.GetOrdinal("PostalCode");
            //ContactInfo
            int ordinalContactId = record.GetOrdinal("ContactId");
            int ordinalContactInfo = record.GetOrdinal("ContactInfo");
            int ordinalContactType = record.GetOrdinal("ContactTypeCode");

            var temp = new Store();
            temp.StoreId = record.GetGuid(ordinalId);
            temp.StoreIdentifier = record.IsDBNull(ordinalIdentifier) ? null : record.GetString(ordinalIdentifier);
            temp.StoreName = record.IsDBNull(ordinalName) ? null : record.GetString(ordinalName); 
            temp.StoreUrl = record.IsDBNull(ordinalUrl) ? null : record.GetString(ordinalUrl); ;
            temp.StoreType = (Common.Enums.StoreType)record.GetInt32(ordinalTypeCode); 
            temp.LogoName = record.IsDBNull(ordinalLogo) ? null : record.GetString(ordinalLogo); 
            temp.OpeningHours = record.IsDBNull(ordinalHours) ? null : record.GetString(ordinalHours);
            if (!record.IsDBNull(ordinalAddressId))
            {
                temp.Address = new General.Address
                {
                    AddressId = record.GetGuid(ordinalAddressId),
                    City = record.IsDBNull(ordinalCity) ? null : record.GetString(ordinalCity),
                    CountryCode = record.IsDBNull(ordinalCountry) ? null : record.GetString(ordinalCountry),
                    Street = record.IsDBNull(ordinalStreet) ? null : record.GetString(ordinalStreet),
                    HouseNumber = record.IsDBNull(ordinalHouseNumber) ? null : record.GetString(ordinalHouseNumber),
                    BoxNumber = record.IsDBNull(ordinalBoxNumber) ? null : record.GetString(ordinalBoxNumber),
                    Postalcode = record.IsDBNull(ordinalPostalCode) ? null : record.GetString(ordinalPostalCode)
                };
            }
            if (!record.IsDBNull(ordinalContactId))
            {
                temp.ContactInformation = new General.ContactInformation
                {
                    ContactId = record.GetGuid(ordinalContactId),
                    ContactInfo = record.IsDBNull(ordinalContactInfo) ? null : record.GetString(ordinalContactInfo),
                    ContactInformationTypeCode = (Common.Enums.ContactInformationType)record.GetInt32(ordinalContactType)
                };
             
            }

            return temp;
        } 
    }
}
