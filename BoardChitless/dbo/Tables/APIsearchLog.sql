CREATE TABLE [dbo].[APIsearchLog] (
    [id]             BIGINT        IDENTITY (1, 1) NOT NULL,
    [searchCriteria] VARCHAR (200) NULL,
    [XMLReturned]    VARCHAR (MAX) NULL,
    [errorReturned]  VARCHAR (MAX) NULL,
    [dateTime]       DATETIME      CONSTRAINT [DF_APIsearchReturn_dateTime] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_APIsearchReturn] PRIMARY KEY CLUSTERED ([id] ASC)
);

