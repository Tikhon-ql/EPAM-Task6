using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SessionLibrary._DAO.Models;
using SessionLibrary.DaoFactory.Models;
using SessionLibrary.Models.Another;

namespace SessionDao.Tests
{
    [TestClass]
    public class SessionDaoUnitTests
    {
        private static SessionFactory factory;
        static SessionDaoUnitTests()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"(localdb)\mssqllocaldb";
            builder.InitialCatalog = @"SessionLibrary.MDF";
            builder.IntegratedSecurity = true;
            builder.AttachDBFilename = @"D:\Тихон\Git\EPAM-Task6\SessionLibrary\SessionLibrary.mdf";
            factory = SessionFactory.GetInstence(builder);
        }
        [DynamicData(nameof(TestMethodCreate),DynamicDataSourceType.Method)]
        [DataTestMethod]
        public void CreateTestMethod(Student student)
        {
            //act
            StudentCreator stCreator = (StudentCreator)factory.GetStudentCreator();
            bool isCreated = stCreator.Create(student);
            //assert
            Assert.IsTrue(isCreated);
        }
        private static IEnumerable<Student[]> TestMethodCreate()
        {
            return new[]
            {
                new Student[] { new Student(15,"Pavel", "Pavlov","Pavlovich", 2,1) },
                new Student[] { new Student(16,"Stas", "Statsov","Stasovich", 3,1) },
            };
        }
        //[DynamicData(nameof(TestMethodRead), DynamicDataSourceType.Method)]
        [TestMethod]
        public void ReadTestMethod()
        {
            //arrange
            Student expected = new Student(1,"Ivan","Ivanov","Ivanovich",1,1);
            //act
            StudentCreator stCreator = (StudentCreator)factory.GetStudentCreator();
            Student actual = stCreator.Read(1);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
