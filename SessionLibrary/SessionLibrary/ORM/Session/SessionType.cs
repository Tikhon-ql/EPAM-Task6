using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary.ORM.Session
{
    /// <summary>
    /// Sessin type's class 
    /// </summary>
    public class SessionType
    {
        /// <summary>
        /// Session type's id property
        /// </summary>
        public int Id { get; private set; }
        /// <summary>
        /// Session type's name property
        /// </summary>
        public string SessionTypeName { get; set; }

        public SessionType(int id, string sessionTypeName)
        {
            Id = id;
            SessionTypeName = sessionTypeName;
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is SessionType type &&
                   Id == type.Id &&
                   SessionTypeName == type.SessionTypeName;
        }

        public override int GetHashCode()
        {
            int hashCode = -1419068980;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SessionTypeName);
            return hashCode;
        }
    }
}
