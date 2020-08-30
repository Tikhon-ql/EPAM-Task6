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
    public class GenderCreator:Dao<Gender>
    {
        public GenderCreator(string str) : base(str) { }
    }
}
