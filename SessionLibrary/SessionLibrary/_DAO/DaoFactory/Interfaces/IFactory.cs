using SessionLibrary._DAO.Interface;
using SessionLibrary._DAO.Models;
using SessionLibrary.Models;
using SessionLibrary.Models.Another;
using SessionLibrary.Models.Session;
using SessionLibrary.Models.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary.DaoFactory.Interfaces
{
    public interface IFactory
    {
        IDao<Student> GetStudentCreator();
        IDao<Gender> GetGenderCreator();
        IDao<Group> GetGroupCreator();
        IDao<Session> GetSessionCreator();
        IDao<SessionShedule> GetSessionSheduleCreator();
        IDao<WorkResult> GetWorkResultCreator();
        IDao<WorkType> GetWorkTypeCreator();
        IDao<Subject> GetSubjectCreator();
        IDao<SessionType> GetSessionTypeCreator();
    }
}
