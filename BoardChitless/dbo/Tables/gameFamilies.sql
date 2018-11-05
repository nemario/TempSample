CREATE TABLE [dbo].[gameFamilies] (
    [gameFamilyID]    BIGINT        IDENTITY (1, 1) NOT NULL,
    [name]            VARCHAR (100) NOT NULL,
    [dateAdded]       DATETIME      CONSTRAINT [DF_gameFamily_dateAdded] DEFAULT (getdate()) NOT NULL,
    [addedBy]         VARCHAR (50)  NOT NULL,
    [dateLastUpdated] DATETIME      NULL,
    [lastUpdatedBy]   VARCHAR (50)  NULL,
    [isActive]        INT           CONSTRAINT [DF_gameFamily2_isActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_gameFamily] PRIMARY KEY CLUSTERED ([gameFamilyID] ASC)
);

