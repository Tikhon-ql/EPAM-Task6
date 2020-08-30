using SessionLibrary.DaoFactory.Models;
using SessionLibrary.Models.Another;
using SessionLibrary.Models.Session;
using SessionLibrary.Models.Work;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary.Excel.DataClasses.Abstract
{
    public abstract class DataClass
    {
        public ICollection<Student> Students { get; set; }
        public ICollection<Group> Groups { get; set; }
        public ICollection<Gender> Genders { get; set; }
        public ICollection<SessionShedule> SessionShedules { get; set; }
        public ICollection<WorkType> WorkTypes { get; set; }
        public ICollection<WorkResult> WorkResults { get; set; }
        public ICollection<Subject> Subjects { get; set; }
        public ICollection<Session> Sessions { get; set; }
        public ICollection<SessionType> SessionTypes { get; set; }
        public DataClass(string connect)
        {
            SessionFactory factory = SessionFactory.GetInstence(connect);
            Students = factory.GetStudentCreator().GetAll();
            Groups = factory.GetGroupCreator().GetAll();
            Sessions = factory.GetSessionCreator().GetAll();
            Genders = factory.GetGenderCreator().GetAll();
            WorkResults = factory.GetWorkResultCreator().GetAll();
            WorkTypes = factory.GetWorkTypeCreator().GetAll();
            Subjects = factory.GetSubjectCreator().GetAll();
            SessionTypes = factory.GetSessionTypeCreator().GetAll();
            SessionShedules = factory.GetSessionSheduleCreator().GetAll();
        }
    }
}
