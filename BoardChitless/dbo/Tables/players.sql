CREATE TABLE [dbo].[players] (
    [playerID]   UNIQUEIDENTIFIER CONSTRAINT [DF_players_playerID] DEFAULT (newid()) NOT NULL,
    [userID]     UNIQUEIDENTIFIER NULL,
    [firstName]  VARCHAR (75)     NULL,
    [lastName]   VARCHAR (75)     NULL,
    [nickName]   VARCHAR (100)    NULL,
    [externalID] VARCHAR (100)    NULL,
    CONSTRAINT [PK_bcUser] PRIMARY KEY CLUSTERED ([playerID] ASC),
    CONSTRAINT [FK_players_system_users] FOREIGN KEY ([userID]) REFERENCES [dbo].[system_users] ([userID])
);

