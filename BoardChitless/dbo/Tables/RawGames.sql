CREATE TABLE [dbo].[RawGames] (
    [ID]              BIGINT         IDENTITY (1, 1) NOT NULL,
    [APIID]           VARCHAR (50)   NULL,
    [Name]            VARCHAR (200)  NULL,
    [YearPublished]   INT            NULL,
    [RecordType]      VARCHAR (200)  NULL,
    [isAlsoExpansion] INT            NULL,
    [TheBlob]         NVARCHAR (MAX) NULL,
    [isProcessed]     INT            CONSTRAINT [DF_bggRawGames_isProcessed] DEFAULT ((0)) NOT NULL,
    [addedBy]         VARCHAR (MAX)  NULL,
    [dateAdded]       DATETIME       CONSTRAINT [DF_bggGamesRaw_dataAdded] DEFAULT (getdate()) NOT NULL,
    [dateLastUpdated] DATETIME       NULL,
    [isActive]        INT            CONSTRAINT [DF_bggGamesRaw_isActive] DEFAULT ((1)) NOT NULL,
    [lastUpdatedBy]   VARCHAR (MAX)  NULL,
    CONSTRAINT [PK_bggGamesRaw] PRIMARY KEY CLUSTERED ([ID] ASC)
);

