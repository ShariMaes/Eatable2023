CREATE TABLE [dbo].[Store]
(
	[StoreId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [StoreIdentifier] NVARCHAR(255) NOT NULL, 
    [StoreName] NVARCHAR(255) NOT NULL, 
    [StoreUrl] NVARCHAR(255) NULL,
    [StoreTypeCode] INT NULL, 
    [LogoName] NVARCHAR(255) NULL, 
    [OpeningHoursJson] NVARCHAR(Max) NULL, 
    [StoreAddressId] UNIQUEIDENTIFIER NULL, 
    [StoreContactInformationId] UNIQUEIDENTIFIER NULL, 
    [Created] DATETIME2 NULL, 
    [CreatedBy] NVARCHAR(255) NULL, 
    [Modified] DATETIME2 NULL, 
    [ModifiedBy] NVARCHAR(255) NULL, 
    CONSTRAINT [FK_Store_StoreType] FOREIGN KEY ([StoreTypeCode]) REFERENCES [StoreType](StoreTypeCodeId), 
    CONSTRAINT [FK_Store_Address] FOREIGN KEY ([StoreAddressId]) REFERENCES [Address]([AddressId]), 
    CONSTRAINT [FK_Store_ContactInformation] FOREIGN KEY ([StoreContactInformationId]) REFERENCES [ContactInformation]([ContactId])
    
)

GO

CREATE INDEX [StoreIdentifier] ON [dbo].[Store] (StoreIdentifier)
