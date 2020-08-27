using SessionLibrary.Models;
using SessionLibrary.Models.Session;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary._DAO.Models
{
    public class SessionCreator:Dao<Session>
    {
        public SessionCreator(SqlConnectionStringBuilder stringBuild) : base(stringBuild) { }
    }
}
