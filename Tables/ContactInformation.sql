CREATE TABLE [dbo].[ContactInformation]
(
	[ContactId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [ObjectId] UNIQUEIDENTIFIER NOT NULL,
    [ContactTypeCode] INT NOT NULL, 
    [ContactInfo] NVARCHAR(50) NOT NULL,
    [Created] DATETIME2 NULL, 
    [CreatedBy] NVARCHAR(255) NULL, 
    [Modified] DATETIME2 NULL, 
    [ModifiedBy] NVARCHAR(255) NULL
     
)
