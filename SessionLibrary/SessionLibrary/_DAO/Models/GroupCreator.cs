using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SessionLibrary._DAO.Models
{
    public class GroupCreator:Dao<Group>
    {
        public GroupCreator(SqlConnectionStringBuilder stringBuild) : base(stringBuild) { }
    }
}
