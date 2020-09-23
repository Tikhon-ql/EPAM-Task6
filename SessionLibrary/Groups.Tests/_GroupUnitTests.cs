using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SessionLibrary._DAO.Models;
using SessionLibrary.DaoFactory.Models;
using SessionLibrary.ORM.Another;

namespace Groups.Tests
{
   
    [TestClass]
    public class _GroupUnitTests
    {
        private static SessionFactory factory;
        static _GroupUnitTests()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"(localdb)\mssqllocaldb";
            builder.InitialCatalog = @"SessionLibrary";
            builder.IntegratedSecurity = true;
            factory = SessionFactory.GetInstence(builder.ConnectionString);
        }
        [DynamicData(nameof(TestMethodCreate), DynamicDataSourceType.Method)]
        [DataTestMethod]
        public void CreateTestMethod(Group group)
        {
            //arrange
            GroupCreator creator = (GroupCreator)factory.GetGroupCreator();
            //act
            bool isCreated = creator.Create(group);
            //assert
            Assert.IsTrue(isCreated);
        }
        private static IEnumerable<Group[]> TestMethodCreate()
        {
            return new[]
            {
                new Group[] { new Group(5,"Group-5") },
                new Group[] { new Group(6,"Group-6") },
            };
        }
        [TestMethod]
        public void ReadTestMethod()
        {
            //arrange
            Group expected = new Group(1, "Group-1");
            //act
            GroupCreator creator = (GroupCreator)factory.GetGroupCreator();
            Group actual = creator.Read(1);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [DataTestMethod]
        [DataRow(5)]
        [DataRow(6)]
        public void DeleteTestMethod(int id)
        {
            //arrange
            GroupCreator creator = (GroupCreator)factory.GetGroupCreator();
            //act
            bool isDeleted = creator.Delete(id);
            //assert
            Assert.IsTrue(isDeleted);
        }
        [DynamicData(nameof(TestMethodUpdate), DynamicDataSourceType.Method)]
        [DataTestMethod]
        public void UpdateTestMethod(Group group)
        {
            //arrange
            GroupCreator creator = (GroupCreator)factory.GetGroupCreator();
            //act
            bool isUpdated = creator.Update(group);
            //assert
            Assert.IsTrue(isUpdated);
        }
        private static IEnumerable<Group[]> TestMethodUpdate()
        {
            return new[]
            {
                new Group[] { new Group(5,"_Group-5") },
                new Group[] { new Group(6,"_Group-6") },
            };
        }
        [TestMethod]
        public void GetAllTestMethod()
        {
            //arrange
            GroupCreator creator = (GroupCreator)factory.GetGroupCreator();
            List<Group> expected = new List<Group> {new Group(1,"Group-1"),
                                                    new Group(2, "Group-2"),
                                                    new Group(3,"Group-3"),
                                                    new Group(4,"Group-4")};
            //act
            List<Group> actual = creator.GetAll().ToList<Group>();
            //assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
