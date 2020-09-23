using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SessionLibrary.Excel.DataClasses;
using SessionLibrary.Excel.Enums;
using SessionLibrary.Excel.Models;

namespace _SessionLIbraryExcel.Tests
{
    [TestClass]
    public class WorkWithExcelUnitTests
    {
        /// <summary>
        /// Connection string
        /// </summary>
        static SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        static WorkWithExcelUnitTests()
        {
            builder.DataSource = @"DESKTOP-7D5VMQO\SQLEXPRESS";
            builder.InitialCatalog = @"SessionLibrary";
            builder.IntegratedSecurity = true;
        }
        /// <summary>
        /// Checing excle worker write students results method
        /// </summary>
        [TestMethod]
        public void ExcelWriteSessionResults()
        {
            //arrange
            SessionResultGetter getter = new SessionResultGetter(builder.ConnectionString);
            List<GroupResult> results = getter.GetSessionResult(1).ToList<GroupResult>();
            //act
            bool flag = ExcelWorker.Write(@"SessionResults.xlsx", results);
            //assert
            Assert.IsTrue(flag);
        }
        /// <summary>
        /// Checing excle worker write students results with sorting
        /// </summary>
        [TestMethod]
        public void ExcelWriteSessionResultsWithSortingByResultAscending()
        {
            //arrange
            SessionResultGetter getter = new SessionResultGetter(builder.ConnectionString);
            List<GroupResult> results = getter.GetSessionResult(1, (i) => i.Result, SortType.Ascending).ToList<GroupResult>();
            //act
            bool flag = ExcelWorker.Write(@"SessionResultsWithSorting.xlsx", results);
            //assert
            Assert.IsTrue(flag);
        }
        /// <summary>
        /// Checing excle worker write group with them average, minimum and maximum results method
        /// </summary>
        [TestMethod]
        public void ExcelWriteGroupAvgMinMax()
        {
            //arrange
            AllGroupsAvgMaxMinGetter getter = new AllGroupsAvgMaxMinGetter(builder.ConnectionString);
            List<GroupsAvgMinMax> results = getter.GetGroupsAvgMinMax().ToList<GroupsAvgMinMax>();
            //act
            bool flag = ExcelWorker.Write(@"GroupAvgMinMax.xlsx", results);
            //assert
            Assert.IsTrue(flag);
        }
        /// <summary>
        /// Checing excle worker write group with them average, minimum and maximum results with sorting
        /// </summary>
        [TestMethod]
        public void ExcelWriteGroupAvgMinMaxWithSortingByMaxDescending()
        {
            //arrange
            AllGroupsAvgMaxMinGetter getter = new AllGroupsAvgMaxMinGetter(builder.ConnectionString);
            List<GroupsAvgMinMax> results = getter.GetGroupsAvgMinMax((i) => i.Max, SortType.Descending).ToList<GroupsAvgMinMax>();
            //act
            bool flag = ExcelWorker.Write(@"GroupAvgMinMaxWithSorting.xlsx", results);
            //assert
            Assert.IsTrue(flag);
        }
        /// <summary>
        /// Checing excle worker write dopout students method
        /// </summary>
        [TestMethod]
        public void ExcelWriteDropOutStudents()
        {
            //arrange
            DropoutStudentsGetter getter = new DropoutStudentsGetter(builder.ConnectionString);
            List<DropOutStudentsByGroup> results = getter.GetExpelStudents().ToList<DropOutStudentsByGroup>();
            //act
            bool flag = ExcelWorker.Write(@"DropoutStudents.xlsx", results);
            //assert
            Assert.IsTrue(flag);
        }
        /// <summary>
        /// Checing excle worker write dopout students with sorting
        /// </summary>
        [TestMethod]
        public void ExcelWriteWithSortingBySurnameAscendingDropOutStudents()
        {
            //arrange
            DropoutStudentsGetter getter = new DropoutStudentsGetter(builder.ConnectionString);
            List<DropOutStudentsByGroup> results = getter.GetExpelStudents((res) => res.Surname, SortType.Ascending).ToList<DropOutStudentsByGroup>();
            //act
            bool flag = ExcelWorker.Write(@"DropoutStudentsAscendingWithSorting.xlsx", results);
            //assert
            Assert.IsTrue(flag);
        }
    }
}
