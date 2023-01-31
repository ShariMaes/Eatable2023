CREATE TABLE [dbo].[ContactInformationType]
(
	[ContactInformationTypeCodeId] INT NOT NULL PRIMARY KEY, 
    [ContactInformationTypeCaption] NVARCHAR(255) NULL, 
    [ResourceId] Uniqueidentifier NOT NULL ,
    [Created] DATETIME2 NULL, 
    [CreatedBy] NVARCHAR(255) NULL, 
    [Modified] DATETIME2 NULL, 
    [ModifiedBy] NVARCHAR(255) NULL, 
    CONSTRAINT [FK_ContactInformationType_Resource] FOREIGN KEY (ResourceId) REFERENCES [Resource]([ResourceId])
    
)
