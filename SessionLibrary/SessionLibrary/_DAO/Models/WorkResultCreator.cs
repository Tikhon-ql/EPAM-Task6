using SessionLibrary.Models;
using SessionLibrary.Models.Work;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary._DAO.Models
{
    public class WorkResultCreator:Dao<WorkResult>
    {
        public WorkResultCreator(string str) : base(str) { }
    }
}
