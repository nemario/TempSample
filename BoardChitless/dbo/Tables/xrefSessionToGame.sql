CREATE TABLE [dbo].[xrefSessionToGame] (
    [xrefSessionToGameID]   UNIQUEIDENTIFIER CONSTRAINT [DF_xrefSessionToGame_xrefSessionToGameID] DEFAULT (newid()) NOT NULL,
    [sessionID]             UNIQUEIDENTIFIER NOT NULL,
    [gameID]                UNIQUEIDENTIFIER NULL,
    [customGameName]        VARCHAR (200)    NULL,
    [votedByPlayerID]       UNIQUEIDENTIFIER NOT NULL,
    [relativeInterestLevel] INT              CONSTRAINT [DF_xrefSessionToGame_relativeInterestLevel] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_xrefSessionToGame] PRIMARY KEY CLUSTERED ([xrefSessionToGameID] ASC),
    CONSTRAINT [FK_xrefSessionToGame_players] FOREIGN KEY ([votedByPlayerID]) REFERENCES [dbo].[players] ([playerID]),
    CONSTRAINT [FK_xrefSessionToGame_session] FOREIGN KEY ([sessionID]) REFERENCES [dbo].[session] ([sessionID])
);

