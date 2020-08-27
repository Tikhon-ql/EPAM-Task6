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
        private static SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
        private static SessionFactory instance;
        public static SessionFactory GetInstence(SqlConnectionStringBuilder builder)
        {
            if(instance == null)
            {
                instance = new SessionFactory();
                stringBuilder = builder;
                return instance;
            }
            return instance;
        }

        public IDao<Group> GetGroupCreator()
        {
            return new GroupCreator(stringBuilder);
        }

        public IDao<Gender> GetGenderCreator()
        {
            return new GenderCreator(stringBuilder);
        }

        public IDao<Session> GetSessionCreator()
        {
            return new SessionCreator(stringBuilder);
        }

        public IDao<SessionShedule> GetSessionSheduleCreator()
        {
            return new SessionSheduleCreator(stringBuilder);
        }

        public IDao<SessionType> GetSessionTypeCreator()
        {
            return new SessionTypeCreator(stringBuilder);
        }

        public IDao<Student> GetStudentCreator()
        {
            return new StudentCreator(stringBuilder);
        }

        public IDao<Subject> GetSubjectCreator()
        {
            return new SubjectCreator(stringBuilder);
        }

        public IDao<WorkResult> GetWorkResultCreator()
        {
            return new WorkResultCreator(stringBuilder);
        }

        public IDao<WorkType> GetWorkTypeCreator()
        {
            return new WorkTypeCreator(stringBuilder);
        }

    }
}
