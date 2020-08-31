using SessionLibrary.Excel.DataClasses;
using SessionLibrary.Excel.DataClasses.Abstract;
using SessionLibrary.ORM.Another;
using SessionLibrary.ORM.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary.Excel.Models
{
    /// <summary>
    /// Dropout students getter 
    /// </summary>
    public class DropoutStudentsGetter : DataClass
    {
        public DropoutStudentsGetter(string connect) : base(connect) { }
        /// <summary>
        /// Get dropout students method
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DropOutStudentsByGroup> GetExpelStudents()
        {
            List<DropOutStudentsByGroup> result = new List<DropOutStudentsByGroup>();
            foreach(Group group in Groups)
            {
                DropOutStudentsByGroup expel = new DropOutStudentsByGroup(group.GroupName);
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
                                expel.DropoutStudent.Add(new DropoutStudent(stud.Name, stud.Surname, stud.MidleName));
                                break;
                            }
                        }
                        else
                        {
                            if(res.Result == "Uncredit")
                            {
                                expel.DropoutStudent.Add(new DropoutStudent(stud.Name, stud.Surname, stud.MidleName));
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
