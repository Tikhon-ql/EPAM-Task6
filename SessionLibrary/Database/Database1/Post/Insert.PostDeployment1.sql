INSERT INTO WorkType (Id,WorkTypeName) VALUES (1,'Examen')
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

insert into SessionShedule(Id,GroupId,[Date],WorkTypeId,SubjectId,SessionId) values (1,1,'2019-10-11',1,1,1)
 GO
insert into SessionShedule(Id,GroupId,[Date],WorkTypeId,SubjectId,SessionId) values (2,2,'2019-15-11',1,2,1)
 GO
insert into SessionShedule(Id,GroupId,[Date],WorkTypeId,SubjectId,SessionId) values (3,3,'2020-10-07',2,3,1)
 GO
insert into SessionShedule(Id,GroupId,[Date],WorkTypeId,SubjectId,SessionId) values (4,4,'2020-14-07',2,4,1)
  GO
insert into SessionShedule(Id,GroupId,[Date],WorkTypeId,SubjectId,SessionId) values (5,1,'2019-13-11',2,4,1)
 GO
insert into SessionShedule(Id,GroupId,[Date],WorkTypeId,SubjectId,SessionId) values (6,2,'2019-14-11',2,3,1)
 GO
insert into SessionShedule(Id,GroupId,[Date],WorkTypeId,SubjectId,SessionId) values (7,3,'2020-15-07',1,2,1)
 GO
insert into SessionShedule(Id,GroupId,[Date],WorkTypeId,SubjectId,SessionId) values (8,4,'2020-16-07',1,1,2)
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



insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values (1,'8',1,1,1)
GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values  (2,'9',2,2,1) 
GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values  (3,'Credit',3,3,2)
GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values  (4,'Credit',4,4,2)
GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values  (5,'Uncredit',5,4,2)
GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values (6,'Credit',6,3,2)
GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values (7,'Credit',7,4,2)
GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values (8,'Uncredit',8,3,2)
GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values (9,'Credit',9,4,2)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values (10,'Credit',10,3,2)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values (11,'2',11,1,1)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values (12,'3',12,2,1)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values (13,'4',13,2,1)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values (14,'6',14,1,1)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values (15,'7',5,2,1)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values (16,'8',2,1,1)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values (17,'8',4,1,1)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values (18,'9',1,2,1)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values (19,'Credit',1,3,2)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values (20,'6',2,1,1)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values (21,'Uncredit',3,4,2)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values (22,'2',4,1,1)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values (23,'3',3,1,1)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values (24,'8',9,1,1)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values (25,'4',8,2,1)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values (26,'7',10,1,1)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values (27,'8',8,1,1)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values (28,'6',9,2,1)
 GO
insert into WorkResult(Id,Result,StudentId,SubjectId,WorkTypeId) values (29,'8',10,2,1)

GO
