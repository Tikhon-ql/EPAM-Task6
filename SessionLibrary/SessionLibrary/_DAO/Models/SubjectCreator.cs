﻿using SessionLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary._DAO.Models
{
    public class SubjectCreator:Dao<Subject>
    {
        public SubjectCreator(SqlConnectionStringBuilder stringBuild) : base(stringBuild) { }
    }
}
}
