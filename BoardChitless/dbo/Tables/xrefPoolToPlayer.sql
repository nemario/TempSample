CREATE TABLE [dbo].[xrefPoolToPlayer] (
    [xrefPoolToPlayerID] UNIQUEIDENTIFIER CONSTRAINT [DF_xrefPoolToPlayer_xrefPoolToPlayerID] DEFAULT (newid()) NOT NULL,
    [playerID]           UNIQUEIDENTIFIER NOT NULL,
    [playerPoolID]       UNIQUEIDENTIFIER NOT NULL,
    [roleID]             UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_xrefPoolToPlayer] PRIMARY KEY CLUSTERED ([xrefPoolToPlayerID] ASC),
    CONSTRAINT [FK_xrefPoolToPlayer_playerPools] FOREIGN KEY ([playerPoolID]) REFERENCES [dbo].[playerPools] ([playerPoolID]),
    CONSTRAINT [FK_xrefPoolToPlayer_players] FOREIGN KEY ([playerID]) REFERENCES [dbo].[players] ([playerID])
);

