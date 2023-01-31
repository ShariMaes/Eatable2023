CREATE TABLE [dbo].[StoreType]
(
	[StoreTypeCodeId] INT NOT NULL IDENTITY(1,1), 
    [StoreTypeCaption] NVARCHAR(255) NULL, 
    [ResourceId] Uniqueidentifier NOT NULL ,
    [Created] DATETIME2 NULL, 
    [CreatedBy] NVARCHAR(255) NULL, 
    [Modified] DATETIME2 NULL, 
    [ModifiedBy] NVARCHAR(255) NULL, 
    CONSTRAINT [AK_StoreType_Id] PRIMARY KEY ([StoreTypeCodeId]), 
    CONSTRAINT [FK_StoreType_Resource] FOREIGN KEY (ResourceId) REFERENCES [Resource]([ResourceId])
    
)
