CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Name] NVARCHAR(255) NOT NULL, 
    [BrandId] INT NOT NULL, 
    [ImageFilePath] NVARCHAR(255) NULL, 
    [NutritionScore] CHAR(10) NULL,
    [EcoScore] CHAR(10) NULL,
    [VolumePerUnit] INT NOT NULL, 
    [ContentOfUnit] NVARCHAR(255) NULL, 
    [DataHash] NVARCHAR(MAX) NULL, 
    [ProductDetailId] INT NULL, 
    [Remark] NVARCHAR(MAX) NULL, 
    [Created] DATETIME2 NULL, 
    [CreatedBy] NVARCHAR(255) NULL, 
    [Modified] DATETIME2 NULL, 
    [ModifiedBy] NVARCHAR(255) NULL, 
    CONSTRAINT [FK_Product_ProductDetail] FOREIGN KEY ([ProductDetailId]) REFERENCES [ProductDetail]([Id]), 
    CONSTRAINT [FK_Product_Brand] FOREIGN KEY ([BrandId]) REFERENCES [Brand]([Id])
)
