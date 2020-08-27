using SessionLibrary.Excel.DataClasses.Abstract;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary.Excel.Models
{
    public class SessionResultGetter:DataClass
    {
        public SessionResultGetter(SqlConnectionStringBuilder builder):base(builder)
        {

        }
    }
}
