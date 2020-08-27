
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary.Models.Session
{
    public class SessionShedule
    {
        public int Id { get; private set; }
        public int GroupId { get; private set; }
        public DateTime Date { get; set; }
        public int SubjectId { get; set; }
        public int WorkTypeId { get; set; }
        public int SessionId { get; set; }

        public SessionShedule(int id, int groupId, DateTime date, int subjectId, int workTypeId,int sesId)
        {
            Id = id;
            GroupId = groupId;
            Date = date;
            SubjectId = subjectId;
            WorkTypeId = workTypeId;
            SessionId = sesId;
        }
    }
}
