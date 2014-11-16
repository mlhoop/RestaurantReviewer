CREATE TABLE [dbo].[Ratings] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [Restaurant] INT            NOT NULL,
    [Rating]     TINYINT        NOT NULL,
    [Name]       NVARCHAR (250) NOT NULL,
    [Email]      NVARCHAR (250) NULL,
    [Comment]    NVARCHAR (250) NULL,
    CONSTRAINT [PK_Ratings] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK__Ratings__Restaurants] FOREIGN KEY ([Restaurant]) REFERENCES [dbo].[Restaurants] ([Id])
);

