﻿

--3
ALTER TABLE [dbo].[SessionShedule]  WITH CHECK ADD CONSTRAINT [FK_dbo.SessionShedule_dbo.Session_SessionId] FOREIGN KEY([SessionId])
REFERENCES [dbo].[Session] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[SessionShedule] CHECK CONSTRAINT [FK_dbo.SessionShedule_dbo.Session_SessionId]
GO