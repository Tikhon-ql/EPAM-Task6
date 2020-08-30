using OfficeOpenXml;
using SessionLibrary._DAO.Interface;
using SessionLibrary._DAO.Models;
using SessionLibrary.DaoFactory.Interfaces;
using SessionLibrary.Models;
using SessionLibrary.Models.Another;
using SessionLibrary.Models.Session;
using SessionLibrary.Models.Work;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary.DaoFactory.Models
{
    public class SessionFactory:IFactory
    {
        private static string connectionString;
        private static SessionFactory instance;
        public static SessionFactory GetInstence(string connectionStr)
        {
            if(instance == null)
            {
                instance = new SessionFactory();
                connectionString = connectionStr;
                return instance;
            }
            return instance;
        }

        public IDao<Group> GetGroupCreator()
        {
            return new GroupCreator(connectionString);
        }

        public IDao<Gender> GetGenderCreator()
        {
            return new GenderCreator(connectionString);
        }

        public IDao<Session> GetSessionCreator()
        {
            return new SessionCreator(connectionString);
        }

        public IDao<SessionShedule> GetSessionSheduleCreator()
        {
            return new SessionSheduleCreator(connectionString);
        }

        public IDao<SessionType> GetSessionTypeCreator()
        {
            return new SessionTypeCreator(connectionString);
        }

        public IDao<Student> GetStudentCreator()
        {
            return new StudentCreator(connectionString);
        }

        public IDao<Subject> GetSubjectCreator()
        {
            return new SubjectCreator(connectionString);
        }

        public IDao<WorkResult> GetWorkResultCreator()
        {
            return new WorkResultCreator(connectionString);
        }

        public IDao<WorkType> GetWorkTypeCreator()
        {
            return new WorkTypeCreator(connectionString);
        }

    }
}
