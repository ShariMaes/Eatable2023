CREATE TABLE [dbo].[Store]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Name] NVARCHAR(255) NOT NULL, 
    [Zipcode] INT NOT NULL, 
    [City] NVARCHAR(255) NULL, 
    [Street] NVARCHAR(255) NULL,
    [HouseNumber] INT NULL,
    [WebsiteUrl] NVARCHAR(255) NULL,
    [TypeCodeId] INT NULL, 
    [LogoFilePath] NVARCHAR(255) NULL, 
    [OpeningHours] XML NULL, 
    [Created] DATETIME2 NULL, 
    [CreatedBy] NVARCHAR(255) NULL, 
    [Modified] DATETIME2 NULL, 
    [ModifiedBy] NVARCHAR(255) NULL, 
    CONSTRAINT [FK_Store_StoreType] FOREIGN KEY ([TypeCodeId]) REFERENCES [StoreType](Id)
    
)
