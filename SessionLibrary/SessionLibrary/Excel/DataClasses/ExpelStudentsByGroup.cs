using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary.Excel.DataClasses
{
    public class ExpelStudentsByGroup
    {
        public string GroupName { get; set; }
        public List<ExpelStudent> ExpelStudents { get; set; }
        public ExpelStudentsByGroup(string groupName)
        {
            GroupName = groupName;
            ExpelStudents = new List<ExpelStudent>();
        }
    }
}
