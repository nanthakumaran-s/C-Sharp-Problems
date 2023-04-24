using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort_Based_on_Last_Name;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Based_on_Last_Name.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void Test1()
        {
            List<string> expected = new List<string>() { "Thomas Aquinas", "Rene Descartes", "David Hume","John Locke" };
            List<string> sorted = Program.SortContacts(new List<string>() { "John Locke", "Thomas Aquinas", "David Hume", "Rene Descartes" }, "ASC");
            for(int i = 0; i < expected.Count; i++)
            {
                if (expected[i] != sorted[i])
                {
                    Assert.Fail();
                    return;
                }
            }
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void Test2()
        {
            List<string> expected = new List<string>() { "Carl Gauss", "Leonhard Euler", "Paul Erdos" };
            List<string> sorted = Program.SortContacts(new List<string>() { "Paul Erdos", "Leonhard Euler", "Carl Gauss" }, "DESC");
            for (int i = 0; i < expected.Count; i++)
            {
                if (expected[i] != sorted[i])
                {
                    Assert.Fail();
                    return;
                }
            }
            Assert.IsTrue(true);
        }
    }
}