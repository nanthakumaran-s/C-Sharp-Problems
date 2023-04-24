using Microsoft.VisualStudio.TestTools.UnitTesting;
using Valid_Name;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Name.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void Test1()
        {
            Assert.IsTrue(Program.ValidName("H. Wells") == true);
        }

        [TestMethod()]
        public void Test2()
        {
            Assert.IsTrue(Program.ValidName("H. G. Wells") == true);
        }

        [TestMethod()]
        public void Test3()
        {
            Assert.IsTrue(Program.ValidName("Herbert G. Wells") == true);
        }

        [TestMethod()]
        public void Test4()
        {
            Assert.IsTrue(Program.ValidName("Herbert George Wells") == true);
        }

        [TestMethod()]
        public void Test5()
        {
            Assert.IsTrue(Program.ValidName("Herbert") == false);
        }

        [TestMethod()]
        public void Test6()
        {
            Assert.IsTrue(Program.ValidName("H Wells") == false);
        }

        [TestMethod()]
        public void Test7()
        {
            Assert.IsTrue(Program.ValidName("h. Wells") == false);
        }

        [TestMethod()]
        public void Test8()
        {
            Assert.IsTrue(Program.ValidName("H. George Wells") == false);
        }

        [TestMethod()]
        public void Test9()
        {
            Assert.IsTrue(Program.ValidName("H. G. W.") == false);
        }

        [TestMethod()]
        public void Test10()
        {
            Assert.IsTrue(Program.ValidName("Herb. G. Wells") == false);
        }
    }
}