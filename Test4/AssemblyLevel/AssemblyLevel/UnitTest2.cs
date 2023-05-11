using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AssemblyLevel
{
    [TestClass]
    public class UnitTest2
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Console.WriteLine("Running UnitTest2 ClassInitialize");
        }
        [ClassCleanup]
        public static void ClassCleanUp()
        {
            Console.WriteLine("Running UnitTest2 ClassCleanUp");
        }
        [TestInitialize]
        public  void TestInitialize()
        {
            Console.WriteLine("Running UnitTest2 TestInitialize");
        }
        [TestCleanup]
        public  void TestCleanup()
        {
            Console.WriteLine("Running UnitTest2 TestCleanup");
        }

        [TestMethod]
        public void TestMethod3()
        {
            Console.WriteLine("Running UnitTest2 TestMethod3");
        }
        [TestMethod]
        public void TestMethod4()
        {
            Console.WriteLine("Running UnitTest2 TestMethod4");
        }
    }
}
