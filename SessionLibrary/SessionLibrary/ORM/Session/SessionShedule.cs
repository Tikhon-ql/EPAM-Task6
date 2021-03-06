﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary.ORM.Session
{
    /// <summary>
    /// Session shedule's class
    /// </summary>
    public class SessionShedule
    {
        /// <summary>
        /// Session shedule's id property
        /// </summary>
        public int Id { get; private set; }
        /// <summary>
        /// Groups's id property
        /// </summary>
        public int GroupId { get; private set; }
        /// <summary>
        /// Work's date property
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Session's id property
        /// </summary>
        public int SessionId { get; set; }

        public SessionShedule(int id, int groupId, DateTime date, int sesId)
        {
            Id = id;
            GroupId = groupId;
            Date = date;
            SessionId = sesId;
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is SessionShedule shedule &&
                   Id == shedule.Id &&
                   GroupId == shedule.GroupId &&
                   Date == shedule.Date &&
                   SessionId == shedule.SessionId;
        }

        public override int GetHashCode()
        {
            int hashCode = 1488984139;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + GroupId.GetHashCode();
            hashCode = hashCode * -1521134295 + Date.GetHashCode();
            hashCode = hashCode * -1521134295 + SessionId.GetHashCode();
            return hashCode;
        }
    }
}
