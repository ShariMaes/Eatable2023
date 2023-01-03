CREATE TABLE [dbo].[ProductDetail]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [IngredientJson] XML NULL,
	[Created] DATETIME2 NULL, 
    [CreatedBy] NVARCHAR(255) NULL, 
    [Modified] DATETIME2 NULL, 
    [ModifiedBy] NVARCHAR(255) NULL,
)
