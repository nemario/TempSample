CREATE TABLE [dbo].[games] (
    [gameID]          BIGINT        IDENTITY (1, 1) NOT NULL,
    [name]            VARCHAR (100) NOT NULL,
    [dateAdded]       DATETIME      CONSTRAINT [DF_games_dateAdded] DEFAULT (getdate()) NOT NULL,
    [addedBy]         VARCHAR (50)  NOT NULL,
    [dateLastUpdated] DATETIME      NULL,
    [lastUpdatedBy]   VARCHAR (50)  NULL,
    [isActive]        INT           CONSTRAINT [DF_games_isActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_games] PRIMARY KEY CLUSTERED ([gameID] ASC)
);

