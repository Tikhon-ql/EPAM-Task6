ALTER TABLE [dbo].[SessionShedule]  WITH CHECK ADD CONSTRAINT [FK_dbo.SessionShedule_dbo.WorkType_WorkTypeId] FOREIGN KEY([WorkTypeId])
REFERENCES [dbo].[WorkType] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[SessionShedule] CHECK CONSTRAINT [FK_dbo.SessionShedule_dbo.WorkType_WorkTypeId]
GO

--2
ALTER TABLE [dbo].[SessionShedule]  WITH CHECK ADD CONSTRAINT [FK_dbo.SessionShedule_dbo.Subject_SubjectId] FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subject] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[SessionShedule] CHECK CONSTRAINT [FK_dbo.SessionShedule_dbo.Subject_SubjectId]
GO

--3
ALTER TABLE [dbo].[SessionShedule]  WITH CHECK ADD CONSTRAINT [FK_dbo.SessionShedule_dbo.Session_SessionId] FOREIGN KEY([SessionId])
REFERENCES [dbo].[Session] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[SessionShedule] CHECK CONSTRAINT [FK_dbo.SessionShedule_dbo.Session_SessionId]
GO