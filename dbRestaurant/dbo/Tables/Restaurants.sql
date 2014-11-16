CREATE TABLE [dbo].[Restaurants] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [Name]           NVARCHAR (250) NOT NULL,
    [Address]        NVARCHAR (250) NULL,
    [City]           NVARCHAR (250) NULL,
    [State]          CHAR (2)       NULL,
    [RestaurantType] INT            NULL,
    CONSTRAINT [PK_Restaurants] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Restaurants_RestaurantType] FOREIGN KEY ([RestaurantType]) REFERENCES [dbo].[RestaurantType] ([Id])
);

