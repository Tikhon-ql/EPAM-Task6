﻿using SessionLibrary.Excel.DataClasses.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary.Excel.DataClasses
{
    public class SessionResult
    {
        public string GroupName { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string StudentMidleName { get; set; }
        public string WorkType { get; set; }
        public string Result { get; set; }

        public SessionResult(string groupName, DateTime date, string subject, string studentName, string studentSurname, string studentMidleName, string workType, string result)
        {
            GroupName = groupName;
            Date = date;
            Subject = subject;
            StudentName = studentName;
            StudentSurname = studentSurname;
            StudentMidleName = studentMidleName;
            WorkType = workType;
            Result = result;
        }
    }
}
