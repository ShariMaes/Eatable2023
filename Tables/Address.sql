CREATE TABLE [dbo].[Address]
(
	[AddressId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [CityName] NVARCHAR(50) NULL, 
    [CountryCode] NVARCHAR(50) NULL, 
    [HouseNumber] NVARCHAR(50) NULL, 
    [PostalCode] NVARCHAR(50) NULL, 
    [BoxNumber] NVARCHAR(50) NULL, 
    [StreetName] NVARCHAR(50) NULL,
    [Created] DATETIME2 NULL, 
    [CreatedBy] NVARCHAR(255) NULL, 
    [Modified] DATETIME2 NULL, 
    [ModifiedBy] NVARCHAR(255) NULL, 
)
