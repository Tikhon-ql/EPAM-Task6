using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SessionLibrary.Excel.DataClasses;
using SessionLibrary.Excel.Models;

namespace SessionLIbraryExcel.Tests
{
    [TestClass]
    public class UnitTest1
    {
       
        static SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        static UnitTest1()
        {
            builder.DataSource = @"(localdb)\mssqllocaldb";
            builder.InitialCatalog = @"SessionLibrary";
            builder.IntegratedSecurity = true;
            builder.AttachDBFilename = @"D:\Тихон\Git\EPAM-Task6\SessionLibrary\SessionLibrary.mdf";
        }
        [TestMethod]
        public void ExcelWriteSessionResults()
        {
            SessionResultGetter getter = new SessionResultGetter(builder.ConnectionString);
            List<GroupResult> results = getter.GetSessionResult(1).ToList<GroupResult>();
            ExcelWorker.WriteSessionResults(@"SessionResults.xlsx",results);
        }
        [TestMethod]
        public void ExcelWriteGroupAvgMinMax()
        {
            AllGroupsAvgMaxMinGetter getter = new AllGroupsAvgMaxMinGetter(builder.ConnectionString);
            List<GroupsAvgMinMax> results = getter.GetGroupsAvgMinMax().ToList<GroupsAvgMinMax>();
            ExcelWorker.WriteGroupAvgMinMax(@"GroupAvgMinMax.xlsx",results);
        }
    }
}
