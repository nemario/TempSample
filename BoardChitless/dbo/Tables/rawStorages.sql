CREATE TABLE [dbo].[rawStorages] (
    [rawStorageID]    BIGINT         IDENTITY (1, 1) NOT NULL,
    [TheBlob]         NVARCHAR (MAX) NOT NULL,
    [addedBy]         VARCHAR (MAX)  NULL,
    [dateAdded]       DATETIME       CONSTRAINT [DF_rawStorage_dataAdded] DEFAULT (getdate()) NOT NULL,
    [dateLastUpdated] DATETIME       NULL,
    [isActive]        INT            CONSTRAINT [DF_rawStorage_isActive] DEFAULT ((1)) NOT NULL,
    [lastUpdatedBy]   VARCHAR (MAX)  NULL,
    [externalID]      VARCHAR (50)   NULL,
    CONSTRAINT [PK_rawStorage] PRIMARY KEY CLUSTERED ([rawStorageID] ASC)
);

