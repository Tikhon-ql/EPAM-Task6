
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary.Models.Session
{
    public class Session
    {
        public int Id { get; private set; }
        public string AcademicYears { get; set; }
        public int SessionTypeId { get; set; }

        public Session()
        {
                
        }
        public Session(int id, int sessionTypeId, string academicYears)
        {
            Id = id;
            AcademicYears = academicYears;
            SessionTypeId = sessionTypeId;
        }
    }
}
