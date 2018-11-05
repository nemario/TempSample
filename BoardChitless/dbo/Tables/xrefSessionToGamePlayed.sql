CREATE TABLE [dbo].[xrefSessionToGamePlayed] (
    [xrefSessionToGamePlayedID] UNIQUEIDENTIFIER CONSTRAINT [DF_xrefSessionToGame_xrefSessionToGamePlayedID] DEFAULT (newid()) NOT NULL,
    [sessionID]                 UNIQUEIDENTIFIER NOT NULL,
    [gameID]                    UNIQUEIDENTIFIER NULL,
    [customGameName]            VARCHAR (200)    NULL,
    [played]                    INT              CONSTRAINT [DF_xrefSessionToGamePlayed_played] DEFAULT ((1)) NOT NULL,
    [orderOfPlay]               INT              NULL,
    CONSTRAINT [PK_xrefSessionToGamePlayed] PRIMARY KEY CLUSTERED ([xrefSessionToGamePlayedID] ASC),
    CONSTRAINT [FK_xrefSessionToGamePlayed_session] FOREIGN KEY ([sessionID]) REFERENCES [dbo].[session] ([sessionID])
);

