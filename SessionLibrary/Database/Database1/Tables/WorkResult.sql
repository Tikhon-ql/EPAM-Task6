﻿CREATE TABLE [dbo].[WorkResult] (
    [Id]         INT           NOT NULL,
    [Result]     NVARCHAR (10) NOT NULL,
    [StudentId]  INT           NOT NULL,
    [SubjectId]  INT           NOT NULL,
    [WorkTypeId] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);