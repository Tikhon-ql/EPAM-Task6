﻿INSERT INTO WorkType (Id,WorkTypeName) VALUES (1,'Examen')
GO
insert into WorkType(Id,WorkTypeName) values (2,'Credit')
go
insert into [Group](Id,GroupName) values (1,'Group-1')
 GO
insert into [Group](Id,GroupName) values (2,'Group-2')
 GO
insert into [Group](Id,GroupName) values (3,'Group-3')
 GO
insert into [Group](Id,GroupName) values (4,'Group-4')
GO
insert into [Subject](Id,SubjectName) values (1,'Math')
 GO
insert into [Subject](Id,SubjectName) values (2,'Physics')
 GO
insert into [Subject](Id,SubjectName) values (3,'Philosophy')
 GO
insert into [Subject](Id,SubjectName) values (4,'Psychology')
GO
insert into Gender(Id,GenderName) values (1,'Male')
 GO
insert into Gender(Id,GenderName) values (2,'Female')
GO

insert into SessionType(Id,SessionTypeName) values (1,'Winter')
 GO
insert into SessionType(Id,SessionTypeName) values (2,'Летняя')
GO




insert into [Session](Id,SessionTypeId,AcademicYears) values (1,1,'2019')
GO
insert into [Session](Id,SessionTypeId,AcademicYears) values (2,2,'2020')
GO

insert into SessionShedule(Id,GroupId,[Date],SessionId) values (1,1,'2019-10-11',1)
 GO
insert into SessionShedule(Id,GroupId,[Date],SessionId) values (2,2,'2019-15-11',1)
 GO
insert into SessionShedule(Id,GroupId,[Date],SessionId) values (3,3,'2020-10-07',1)
 GO
insert into SessionShedule(Id,GroupId,[Date],SessionId) values (4,4,'2020-14-07',1)
  GO
insert into SessionShedule(Id,GroupId,[Date],SessionId) values (5,1,'2019-13-11',1)
 GO
insert into SessionShedule(Id,GroupId,[Date],SessionId) values (6,2,'2019-14-11',1)
 GO
insert into SessionShedule(Id,GroupId,[Date],SessionId) values (7,3,'2020-15-07',1)
 GO
insert into SessionShedule(Id,GroupId,[Date],SessionId) values (8,4,'2020-16-07',2)
GO






insert into Student(Id,[Name],Surname,MidleName,GenderId,GroupId) values (1,'Ivan','Ivanov','Ivanovich',1,1)
GO
insert into Student(Id,[Name],Surname,MidleName,GenderId,GroupId) values (2,'Andrey','Andreev','Andreevich',1,1)
GO
insert into Student(Id,[Name],Surname,MidleName,GenderId,GroupId) values (3,'Sergey','Sergeev','Sergeevich',1,1)
GO
insert into Student(Id,[Name],Surname,MidleName,GenderId,GroupId) values (4,'Anna','Ivanova','Ivanovna',2,1)
GO
insert into Student(Id,[Name],Surname,MidleName,GenderId,GroupId) values (5,'Alexandra','Krasnova','Sergeevna',2,2)
GO
insert into Student(Id,[Name],Surname,MidleName,GenderId,GroupId) values (6,'Petr','Petrov','Petrovich',1,2)
GO
insert into Student(Id,[Name],Surname,MidleName,GenderId,GroupId) values (7,'Evgeniy','Kirpitch','Victorivich',1,2)
GO
insert into Student(Id,[Name],Surname,MidleName,GenderId,GroupId) values (8,'Stepan','Stepanov','Stepanovich',1,3)
GO
insert into Student(Id,[Name],Surname,MidleName,GenderId,GroupId) values (9,'Maxim','Maximov','Maximovich',1,3)
GO
insert into Student(Id,[Name],Surname,MidleName,GenderId,GroupId) values (10,'Oleg','Ryba','Olegovich',1,3)
GO
insert into Student(Id,[Name],Surname,MidleName,GenderId,GroupId) values (11,'Ecaterina','Pervaya','Alecseevna',2,4)
GO
insert into Student(Id,[Name],Surname,MidleName,GenderId,GroupId) values (12,'Ilya','Ilyn','Ivanovich',1,4)
GO
insert into Student(Id,[Name],Surname,MidleName,GenderId,GroupId) values (13,'Denis','Denisov','Denisovich',1,4)
GO
insert into Student(Id,[Name],Surname,MidleName,GenderId,GroupId) values (14,'Sonya','Sonnaya','Genadyena',2,4)
GO



insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values (1,'8',1,1,1,1)
GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values  (2,'9',2,2,1,2) 
GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values  (3,'Credit',3,3,2,3)
GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values  (4,'Credit',4,4,2,4)
GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values  (5,'Uncredit',5,4,2,5)
GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values (6,'Credit',6,3,2,6)
GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values (7,'Credit',7,4,2,7)
GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values (8,'Uncredit',8,3,2,8)
GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values (9,'Credit',9,4,2,1)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values (10,'Credit',10,3,2,2)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values (11,'2',11,1,1,3)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values (12,'3',12,2,1,4)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values (13,'4',13,2,1,5)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values (14,'6',14,1,1,6)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values (15,'7',5,2,1,7)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values (16,'8',2,1,1,8)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values (17,'8',4,1,1,1)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values (18,'9',1,2,1,2)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values (19,'Credit',1,3,2,3)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values (20,'6',2,1,1,4)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values (21,'Uncredit',3,4,2,5)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values (22,'2',4,1,1,6)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values (23,'3',3,1,1,7)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values (24,'8',9,1,1,8)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values (25,'4',8,2,1,1)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values (26,'7',10,1,1,2)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values (27,'8',8,1,1,3)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values (28,'6',9,2,1,4)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId,SessionSheduleId) values (29,'8',10,2,1,5)

GO
