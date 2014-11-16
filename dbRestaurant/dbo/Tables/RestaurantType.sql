CREATE TABLE [dbo].[RestaurantType] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Description] NVARCHAR (250) NOT NULL,
    CONSTRAINT [PK_RestaurantType] PRIMARY KEY CLUSTERED ([Id] ASC)
);

