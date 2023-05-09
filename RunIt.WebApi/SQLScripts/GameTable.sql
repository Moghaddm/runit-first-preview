CREATE TABLE [dbo].[Games](
    [Id] [bigint] PRIMARY KEY IDENTITY NOT NULL,
    [FullName] [nvarchar(100)],
    [Title] [nvarchar(50)],
    [Image] [varbinary(MAX)],
    [Release] [INT],
    [Rate] [INT] NOT NULL);