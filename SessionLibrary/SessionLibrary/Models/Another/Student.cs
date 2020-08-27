
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary.Models.Another
{
    public class Student
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MidleName { get; set; }
        public DateTime Birthday { get; set; }
        public int GroupId { get; private set; }
        public int GenderId { get; private set; }

        public Student(int id, string name, string surname, string midleName,DateTime brthd, int group, int gender)
        {
            Id = id;
            Name = name;
            Surname = surname;
            MidleName = midleName;
            GroupId = group;
            GenderId = gender;
            Birthday = brthd;
        }
      

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   Id == student.Id &&
                   Name == student.Name &&
                   Surname == student.Surname &&
                   MidleName == student.MidleName &&
                   GroupId == student.GroupId &&
                   GenderId == student.GenderId;
        }

        public override int GetHashCode()
        {
            int hashCode = 829902979;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MidleName);
            hashCode = hashCode * -1521134295 + GroupId.GetHashCode();
            hashCode = hashCode * -1521134295 + GenderId.GetHashCode();
            return hashCode;
        }
    }
}
