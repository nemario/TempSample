CREATE TABLE [dbo].[playerPools] (
    [playerPoolID]    UNIQUEIDENTIFIER CONSTRAINT [DF_playerPools_playerPoolID] DEFAULT (newid()) NOT NULL,
    [poolName]        VARCHAR (250)    NULL,
    [ownedByPlayerID] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_playerPools] PRIMARY KEY CLUSTERED ([playerPoolID] ASC),
    CONSTRAINT [FK_playerPools_players] FOREIGN KEY ([ownedByPlayerID]) REFERENCES [dbo].[players] ([playerID])
);

