CREATE TABLE [dbo].[playerFriends] (
    [playerFriendID]     UNIQUEIDENTIFIER NOT NULL,
    [playerID]           UNIQUEIDENTIFIER NOT NULL,
    [friendID]           UNIQUEIDENTIFIER NOT NULL,
    [typeOfRelationship] INT              CONSTRAINT [DF_playerFriends_typeOfRelationship] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_playerFriends] PRIMARY KEY CLUSTERED ([playerFriendID] ASC),
    CONSTRAINT [FK_playerFriends_players] FOREIGN KEY ([playerID]) REFERENCES [dbo].[players] ([playerID]),
    CONSTRAINT [FK_playerFriends_players1] FOREIGN KEY ([friendID]) REFERENCES [dbo].[players] ([playerID])
);

