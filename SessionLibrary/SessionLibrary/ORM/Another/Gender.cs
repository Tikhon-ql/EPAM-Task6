using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary.ORM.Another
{
    /// <summary>
    /// Gender's class
    /// </summary>
    public class Gender
    {
        /// <summary>
        /// Gender's id property
        /// </summary>
        public int Id { get; private set; }
        /// <summary>
        /// Gender's name property
        /// </summary>
        public string GenderName { get; set; }
        public Gender(int id, string genderName)
        {
            Id = id;
            GenderName = genderName;
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is Gender gender &&
                   Id == gender.Id &&
                   GenderName == gender.GenderName;
        }

        public override int GetHashCode()
        {
            int hashCode = -146968061;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GenderName);
            return hashCode;
        }
    }
}
