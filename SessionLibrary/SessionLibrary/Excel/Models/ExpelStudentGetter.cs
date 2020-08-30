using SessionLibrary.Excel.DataClasses;
using SessionLibrary.Excel.DataClasses.Abstract;
using SessionLibrary.Models.Another;
using SessionLibrary.Models.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary.Excel.Models
{
    public class ExpelStudentGetter : DataClass
    {
        public ExpelStudentGetter(string connect) : base(connect) { }
        public IEnumerable<ExpelStudentsByGroup> GetExpelStudents()
        {
            List<ExpelStudentsByGroup> result = new List<ExpelStudentsByGroup>();
            foreach(Group group in Groups)
            {
                ExpelStudentsByGroup expel = new ExpelStudentsByGroup(group.GroupName);
                List<Student> students = Students.Where(s => s.GroupId == group.Id).ToList();
                foreach(Student stud in students)
                {
                    List<WorkResult> workResults = WorkResults.Where(w => w.StudentId == stud.Id).ToList();
                    foreach(WorkResult res in workResults)
                    {
                        if(res.WorkTypeId == 1)
                        {
                            if(int.Parse(res.Result) <= 3)
                            {
                                expel.ExpelStudents.Add(new ExpelStudent(stud.Name, stud.Surname, stud.MidleName));
                                break;
                            }
                        }
                        else
                        {
                            if(res.Result == "Uncredit")
                            {
                                expel.ExpelStudents.Add(new ExpelStudent(stud.Name, stud.Surname, stud.MidleName));
                                break;
                            }
                        }
                    }
                }
                result.Add(expel);
            }
            return result;
        }
    }
}
