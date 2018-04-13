CREATE TABLE [dbo].[Table] (
    [Id]       INT          NOT NULL,
    [username] VARCHAR (50) NOT NULL,
    [password] CHAR (10)    NOT NULL,
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

