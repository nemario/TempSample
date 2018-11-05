CREATE TABLE [dbo].[system_users] (
    [userID]   UNIQUEIDENTIFIER NOT NULL,
    [username] VARCHAR (200)    NULL,
    [password] VARCHAR (200)    NULL,
    CONSTRAINT [PK_system_users] PRIMARY KEY CLUSTERED ([userID] ASC)
);

