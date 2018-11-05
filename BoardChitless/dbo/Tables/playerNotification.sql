CREATE TABLE [dbo].[playerNotification] (
    [playerNotificationID] UNIQUEIDENTIFIER NOT NULL,
    [playerID]             UNIQUEIDENTIFIER NOT NULL,
    [emailAddress]         VARCHAR (200)    NULL,
    [textNotification]     VARCHAR (10)     NULL,
    CONSTRAINT [PK_playerNotification] PRIMARY KEY CLUSTERED ([playerNotificationID] ASC),
    CONSTRAINT [FK_playerNotification_players] FOREIGN KEY ([playerID]) REFERENCES [dbo].[players] ([playerID])
);

