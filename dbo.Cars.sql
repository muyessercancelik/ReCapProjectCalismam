CREATE TABLE [dbo].[Cars] (
    [Id]    INT          NOT NULL,
    [CarId] INT          NOT NULL,
    [Name]  VARCHAR (50) NOT NULL,
    [BrandId] INT NOT NULL, 
    [ColorId] INT NOT NULL, 
    [ModelYear] VARCHAR(50) NOT NULL, 
    [DailyPrice] MONEY NOT NULL, 
    [Description] VARCHAR(50) NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

