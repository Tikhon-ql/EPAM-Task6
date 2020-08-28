using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary.Excel.DataClasses
{
    public class GroupResult
    {
        public string GroupName { get; set; }
        public ICollection<StudentResult> StudentResults { get; set; }
        public GroupResult(string groupName)
        {
            GroupName = groupName;
        }
    }
}
