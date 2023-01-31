CREATE TABLE [dbo].[ContactInformationType]
(
	[ContactInformationTypeCodeId] INT NOT NULL IDENTITY(1,1), 
    [ContactInformationTypeCaption] NVARCHAR(255) NULL, 
    [ResourceId] Uniqueidentifier NOT NULL ,
    [Created] DATETIME2 NULL, 
    [CreatedBy] NVARCHAR(255) NULL, 
    [Modified] DATETIME2 NULL, 
    [ModifiedBy] NVARCHAR(255) NULL, 
    CONSTRAINT [AK_ContactInformationType_Id] PRIMARY KEY ([ContactInformationTypeCodeId]), 
    CONSTRAINT [FK_ContactInformationType_Resource] FOREIGN KEY (ResourceId) REFERENCES [Resource]([ResourceId])
    
)
