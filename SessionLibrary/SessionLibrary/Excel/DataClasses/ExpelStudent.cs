using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary.Excel.DataClasses
{
    public class ExpelStudent
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MidleName { get; set; }

        public ExpelStudent(string name, string surname, string midleName)
        {
            Name = name;
            Surname = surname;
            MidleName = midleName;
        }
    }
}
