CREATE TABLE [dbo].[session] (
    [sessionID]             UNIQUEIDENTIFIER CONSTRAINT [DF_session_sessionID] DEFAULT (newid()) NOT NULL,
    [sessionName]           VARCHAR (300)    NULL,
    [playerPoolID]          UNIQUEIDENTIFIER NULL,
    [startDateTime]         DATETIME         NULL,
    [expectedDurationInMin] INT              NULL,
    [Description]           NVARCHAR (1000)  NULL,
    CONSTRAINT [PK_session] PRIMARY KEY CLUSTERED ([sessionID] ASC),
    CONSTRAINT [FK_session_playerPools] FOREIGN KEY ([playerPoolID]) REFERENCES [dbo].[playerPools] ([playerPoolID])
);

