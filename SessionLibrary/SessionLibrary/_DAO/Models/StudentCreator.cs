using SessionLibrary._DAO.Interface;
using SessionLibrary.Models;
using SessionLibrary.Models.Another;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary._DAO.Models
{
    public class StudentCreator : Dao<Student>
    {
        public StudentCreator(string str) : base(str) { }
    }
}
