using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassCollection;

namespace TestClassesOperations
{
    [TestClass]
    public class OperationTest
    {
        [TestMethod]
        public void TestPersonHandler()
        {
            Person p1 = PersonHandler.CreatPerson("Ahmad", "Al Hafar");
            Assert.AreEqual(p1.FName, "Ahmad");
            Assert.AreEqual(p1.LNname, "Al Hafar");
            p1 = PersonHandler.CreatPerson(38, "Ahmad", "Al Hafar", 188, 120);
            Person p2 = new Person();
            p2.Age = 38; p2.FName = "Ahmad";p2.LNname = "Al Hafar";p2.Height = 188;p2.Weight = 120;
            Assert.AreEqual(p1.FName, p2.FName);
            Assert.AreEqual(p1.LNname, p2.LNname);
            Assert.AreEqual(p1.Height, p2.Height); 
            Assert.AreEqual(p1.Age, p2.Age);
        }

    }
}
