using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary.Excel.DataClasses
{
    public class GroupsAvgMinMax
    {
        public string GroupName { get; set; }
        public double Min { get; set; }
        public double Avg { get; set; }
        public double Max { get; set; }

        public GroupsAvgMinMax(string groupName, double min, double avg, double max)
        {
            GroupName = groupName;
            Min = min;
            Avg = Math.Round(avg,2);
            Max = max;
        }
    }
}
