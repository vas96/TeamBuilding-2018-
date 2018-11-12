using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;
using TeamBuilding;

namespace TeamBuildingTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConnectionToDBTest()
        {
          TeamBuildingEntities _Instance = null ;
       
            Assert.IsNull(_Instance);

        }

        [TestMethod]
        public void AddProjectTest()
        {         
            Projects test = new Projects();

            test.PrjtId = 1;
            test.PrjtName = "test";

            Assert.AreEqual(test.PrjtId, 1);
            Assert.AreEqual(test.PrjtName, "test");
        }

        [TestMethod]
        public void AddUserTest()
        {

            Users test = new Users();

            test.UsrId = 1;
            test.Name = "testName";
            test.Bio = "naniiii";

            Assert.AreEqual(test.UsrId, 1);
            Assert.AreEqual(test.Name, "testName");
            Assert.AreEqual(test.Bio, "naniiii");
        }

        [TestMethod]
        public void AddSkillTest()
        {

            Skills test = new Skills();

            test.SklId = 1;
            test.SklName = "tester";
            
            Assert.AreEqual(test.SklId, 1);
            Assert.AreEqual(test.SklName, "tester");
            
        }

        [TestMethod]
        public void AddClassTest()
        {

            Classes test = new Classes();

            test.ClassId = 1;
            test.ClassName = "c#";

            Assert.AreEqual(test.ClassId, 1);
            Assert.AreEqual(test.ClassName, "c#");

        }


        [TestMethod]
        public void CreateProjectIsNotNulll()
        {
            Projects test = new Projects();

            test.PrjtId = 1;
            test.PrjtName = "test";

            Assert.IsNotNull(test);
           
        }

        [TestMethod]
        public void CreateUserIsNotNulll()
        {

            Users test = new Users();

            test.UsrId = 1;
            test.Name = "testName";
            test.Bio = "naniiii";

            Assert.IsNotNull(test);
        }

        [TestMethod]
        public void CreateSkilltIsNotNulll()
        {

            Skills test = new Skills();

            test.SklId = 1;
            test.SklName = "tester";

            Assert.IsNotNull(test);

        }

        [TestMethod]
        public void CreateClassIsNotNulll()
        {

            Classes test = new Classes();

            test.ClassId = 1;
            test.ClassName = "c#";

            Assert.IsNotNull(test);

        }
    }
}
