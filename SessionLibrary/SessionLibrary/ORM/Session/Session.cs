
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary.ORM.Session
{
    /// <summary>
    /// Session's class
    /// </summary>
    public class Session
    {
        /// <summary>
        /// Session's id property
        /// </summary>
        public int Id { get; private set; }
        /// <summary>
        /// Session's academic years property
        /// </summary>
        public string AcademicYears { get; set; }
        /// <summary>
        /// Session type's id property
        /// </summary>
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

        public override bool Equals(object obj)
        {
            return obj != null && obj is Session session &&
                   Id == session.Id &&
                   AcademicYears == session.AcademicYears &&
                   SessionTypeId == session.SessionTypeId;
        }

        public override int GetHashCode()
        {
            int hashCode = -1646005154;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AcademicYears);
            hashCode = hashCode * -1521134295 + SessionTypeId.GetHashCode();
            return hashCode;
        }
    }
}
