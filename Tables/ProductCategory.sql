CREATE TABLE [dbo].[ProductCategory]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[EnumCaption] NVARCHAR(255) NOT NULL,
    [Caption] NVARCHAR(255) NOT NULL, 
    [CodeCountry] NCHAR(10) NOT NULL, 
    [CodeLanguage] NCHAR(10) NOT NULL, 
    [IsFood] BIT NULL, 
    [IsBeverage] BIT NULL, 
    [Created] DATETIME2 NULL, 
    [CreatedBy] NVARCHAR(255) NULL, 
    [Modified] DATETIME2 NULL, 
    [ModifiedBy] NVARCHAR(255) NULL, 
    [ValidFrom] DATETIME2 NULL, 
    [ValidUntil] DATETIME2 NULL,
    CONSTRAINT [PK_ProdCatIdEnumCountryLanguage] UNIQUE ([Id], [EnumCaption], [CodeCountry], [CodeLanguage]), 
    CONSTRAINT [AK_ProductCategory_Id] PRIMARY KEY ([Id])
)
