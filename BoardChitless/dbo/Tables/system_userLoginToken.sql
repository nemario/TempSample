CREATE TABLE [dbo].[system_userLoginToken] (
    [userLoginToken] UNIQUEIDENTIFIER CONSTRAINT [DF_system_userLoginToken_userLoginToken] DEFAULT (newid()) NOT NULL,
    [userID]         UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_system_userLoginToken] PRIMARY KEY CLUSTERED ([userLoginToken] ASC),
    CONSTRAINT [FK_system_userLoginToken_system_users] FOREIGN KEY ([userID]) REFERENCES [dbo].[system_users] ([userID])
);

