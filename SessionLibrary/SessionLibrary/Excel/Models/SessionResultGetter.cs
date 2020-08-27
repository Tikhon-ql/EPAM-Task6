﻿using SessionLibrary.Excel.DataClasses;
using SessionLibrary.Excel.DataClasses.Abstract;
using SessionLibrary.Models.Another;
using SessionLibrary.Models.Session;
using SessionLibrary.Models.Work;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary.Excel.Models
{
    public class SessionResultGetter:DataClass
    {
        public SessionResultGetter(SqlConnectionStringBuilder builder):base(builder){ }
        public ICollection<SessionResult> GetSessionResult(int sessionId)
        {
            Session currentSession = Sessions.FirstOrDefault(s => s.Id == sessionId);
            SessionShedule shedule = SessionShedules.FirstOrDefault(s => s.SessionId == currentSession.Id);
            List<SessionResult> results = new List<SessionResult>();
            foreach(Group group in Groups)
            {
                List<Student> students = Students.Where(s => s.GroupId == group.Id).ToList();
                foreach(Student student in students)
                {
                    List<WorkResult> workResults = WorkResults.Where(w => w.StudentId == student.Id).ToList();
                    foreach(WorkResult item in workResults)
                    {
                        Subject subject = Subjects.FirstOrDefault(s => s.Id == item.SubjectId);
                        WorkType type = WorkTypes.FirstOrDefault(w => w.Id == item.WorkTypeId);
                        results.Add(new SessionResult(group.GroupName,shedule.Date,subject.SubjectName,student.Name,student.Surname,student.MidleName,type.WorkTypeName,item.Result));
                    }
                }
            }
            return results;
        }
    }
}
