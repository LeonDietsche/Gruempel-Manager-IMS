﻿use GruempelDB;

DROP TABLE IF EXISTS [dbo].[PLAYER];
DROP TABLE IF EXISTS [dbo].[TEAMS];
DROP TABLE IF EXISTS [dbo].[ADDRESS];



CREATE TABLE [dbo].[ADDRESS] (
    [ID]          INT           IDENTITY (1, 1) NOT NULL,
    [STREET]      VARCHAR (128) NULL,
    [HOUSENUMBER] VARCHAR (128) NULL,
    [ZIP]         VARCHAR (128) NULL,
    [CITY]        VARCHAR (128) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

CREATE TABLE [dbo].[TEAMS] (
    [ID]     INT	IDENTITY (1, 1)        NOT NULL,
    [NAME]   VARCHAR (128) NULL,
    [PUNKTE] INT  NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

CREATE TABLE [dbo].[PLAYER] (
    [ID]            INT           IDENTITY (1, 1) NOT NULL,
    [VORNAME]       VARCHAR (MAX) NULL,
    [NACHNAME]      VARCHAR (MAX) NULL,
    [TELEFONNUMMER] VARCHAR (10)  NULL,
    [ID_ADDRESS]    INT           NULL,
    [ID_TEAMS]      INT           NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([ID_ADDRESS]) REFERENCES [dbo].[ADDRESS] ([ID]),
    FOREIGN KEY ([ID_TEAMS]) REFERENCES [dbo].[TEAMS] ([ID])
);