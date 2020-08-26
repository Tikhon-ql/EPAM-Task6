using SessionLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary._DAO.Models
{
    public class SessionSheduleCreator:Dao<SessionShedule>
    {
        public SessionSheduleCreator(SqlConnectionStringBuilder stringBuild) : base(stringBuild) { }
    }
}
