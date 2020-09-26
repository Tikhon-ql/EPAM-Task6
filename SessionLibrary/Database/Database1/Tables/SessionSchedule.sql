﻿CREATE TABLE [dbo].[SessionShedule] (
    [Id]         INT      NOT NULL,
    [GroupId]    INT      NOT NULL,
    [Date]       DATETIME NOT NULL,
    [WorkTypeId] INT      NOT NULL,
    [SubjectId]  INT      NOT NULL,
    [SessionId]  INT      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);