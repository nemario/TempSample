CREATE TABLE [dbo].[xrefSessionToPlayer] (
    [xrefSessionToPlayerID] UNIQUEIDENTIFIER NOT NULL,
    [sessionID]             UNIQUEIDENTIFIER NOT NULL,
    [playerID]              UNIQUEIDENTIFIER NOT NULL,
    [customInvitedByID]     UNIQUEIDENTIFIER NULL,
    [LikliehoodRating]      INT              NULL,
    [attended]              BIT              NULL,
    [leftEarly]             BIT              NULL,
    CONSTRAINT [PK_xrefSessionToPlayer] PRIMARY KEY CLUSTERED ([xrefSessionToPlayerID] ASC),
    CONSTRAINT [FK_xrefSessionToPlayer_players] FOREIGN KEY ([playerID]) REFERENCES [dbo].[players] ([playerID]),
    CONSTRAINT [FK_xrefSessionToPlayer_players1] FOREIGN KEY ([customInvitedByID]) REFERENCES [dbo].[players] ([playerID]),
    CONSTRAINT [FK_xrefSessionToPlayer_session] FOREIGN KEY ([sessionID]) REFERENCES [dbo].[session] ([sessionID])
);

