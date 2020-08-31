﻿using SessionLibrary.Excel.DataClasses;
using SessionLibrary.Excel.DataClasses.Abstract;
using SessionLibrary.ORM.Another;
using SessionLibrary.ORM.Work;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary.Excel.Models
{
    public class AllGroupsAvgMaxMinGetter : DataClass
    {
        public AllGroupsAvgMaxMinGetter(string connect) : base(connect) { }
        public IEnumerable<GroupsAvgMinMax> GetGroupsAvgMinMax()
        {
            List<GroupsAvgMinMax> results = new List<GroupsAvgMinMax>();
            foreach (Group item in Groups)
            {
                List<WorkResult> groupResults = new List<WorkResult>();
                List<Student> students = Students.Where(s => s.GroupId == item.Id).ToList();
                foreach (Student stud in students)
                {
                    List<WorkResult> workResults = WorkResults.Where(w => w.StudentId == stud.Id).ToList();
                    foreach (WorkResult res in workResults)
                    {
                        if(res.WorkTypeId == 1)
                        {
                            groupResults.Add(res);
                        }
                    }
                }
                if(groupResults.Count != 0)
                    results.Add(new GroupsAvgMinMax(item.GroupName, groupResults.Min(r => Convert.ToInt32(r.Result)), groupResults.Average(r => Convert.ToInt32(r.Result)), groupResults.Max(r => Convert.ToInt32(r.Result))));
            }
            return results;
        }
    }
}