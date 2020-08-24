
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary.Models
{
    public class Session
    {
        public int Id { get; private set; }
        public string AcademicYears { get; set; }
        public int SessionTypeId { get; set; }

        public Session(int id, string academicYears, int sessionTypeId)
        {
            Id = id;
            AcademicYears = academicYears;
            SessionTypeId = sessionTypeId;
        }
        public void GetSessionResults()
        {
           
        }
    }
}
