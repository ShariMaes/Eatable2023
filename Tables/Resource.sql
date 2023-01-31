CREATE TABLE [dbo].[Resource]
(
	[ResourceId] Uniqueidentifier NOT NULL PRIMARY KEY, 
    [ResourceType] NVARCHAR(50) NOT NULL, 
    [Nld] NVARCHAR(255) NOT NULL, 
    [Fr] NVARCHAR(255) NOT NULL, 
    [Eng] NVARCHAR(255) NOT NULL, 
    [Deu] NVARCHAR(255) NOT NULL, 
    [ResourceIdentifier] NVARCHAR(255) NOT NULL,
	[Created] DATETIME2 NULL, 
    [CreatedBy] NVARCHAR(255) NULL, 
    [Modified] DATETIME2 NULL, 
    [ModifiedBy] NVARCHAR(255) NULL, 

)
