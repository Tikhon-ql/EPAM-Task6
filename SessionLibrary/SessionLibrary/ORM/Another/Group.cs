using SessionLibrary._DAO.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary.ORM.Another
{
    /// <summary>
    /// Group's class
    /// </summary>
    public class Group
    {
        /// <summary>
        /// Group's id property
        /// </summary>
        public int Id { get; private set; }
        /// <summary>
        /// Group's name property
        /// </summary>
        public string GroupName { get; set; }

        public Group(int id, string groupName)
        {
            Id = id;
            GroupName = groupName;
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is Group group &&
                   Id == group.Id &&
                   GroupName == group.GroupName;
        }

        public override int GetHashCode()
        {
            int hashCode = -218446265;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GroupName);
            return hashCode;
        }
    }
}
