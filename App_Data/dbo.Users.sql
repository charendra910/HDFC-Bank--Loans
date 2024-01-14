CREATE TABLE [dbo].[Users] (
    [id] INT    NOT NULL IDENTITY,
    [Username]  VARCHAR(50) NULL,
    [Password ] VARCHAR(50) NULL, 
    PRIMARY KEY CLUSTERED ([id] ASC)
);

