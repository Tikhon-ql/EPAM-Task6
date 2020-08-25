using SessionLibrary.Factory.Interfaces;
using SessionLibrary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary.DaoFactory.Models
{
    public class SessionFactory:IFactory
    {

        public Student CreateStudent(int id, string name, string surname, string midleName, int group, int gender)
        {
            return new Student(id, name, surname, midleName, group, gender);
        }

        public Group CreateStudent(int id, string groupName)
        {
            return new Group(id, groupName);
        }

        public SessionShedule CreatSessionShedule(int id, int groupId, DateTime date, int subjectId, int workTypeId)
        {
            return new SessionShedule(id, groupId, date, subjectId, workTypeId);
        }

        public Session CreatSession(int id, string academicYears, int sessionTypeId)
        {
            return new Session(id, academicYears, sessionTypeId);
        }

        public Subject CreatSubject(int id, string subjectName)
        {
            return new Subject(id, subjectName);
        }
    }
}
