using SessionLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary.DaoFactory.Interfaces
{
    public interface IFactory
    {
        Student CreateStudent(int id, string name, string surname, string midleName, int group, int gender);
        Group CreateStudent(int id, string groupName);
        SessionShedule CreatSessionShedule(int id, int groupId, DateTime date, int subjectId, int workTypeId);
        Session CreatSession(int id, string academicYears, int sessionTypeId);
        Subject CreatSubject(int id, string subjectName);
    }
}
