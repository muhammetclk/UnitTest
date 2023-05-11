using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AssemblyLevel
{
    //Test projemizde kactane testclassi olursa olsun bir tane AssaeblyInitialize ve AssemblyCleanup olur.
    //UnitTest2 de olursa hata verir.AssemblyLEvel projesi icnde oldugu ıcın.
    //Test classimizda 1 tane classInitalize ve ClassCleanup olur.
    //Test classimizda 1 tane TestInitalize ve TestCleanup olur.
    

    [TestClass]
    public class UnitTest1
    {
        [AssemblyInitialize]//ilk calisacak olan metod
        public static void AssemblyInitialize(TestContext context)
        {
            Console.WriteLine("Running AssemblyInitialize");
        }
        [AssemblyCleanup]//son calisacak olan metod
        public static void AssemblyCleanUp( )
        {
            Console.WriteLine("Running  AssemblyCleanUp");
        }
        [ClassInitialize]
        public static void ClassInitialize(TestContext context )
        {
            Console.WriteLine("Running UnitTest1 ClassInitialize");
        }
        [ClassCleanup]
        public static void ClassCleanUp( )
        {
            Console.WriteLine("Running UnitTest1 ClassCleanUp");
        }
        [TestInitialize]
        public  void TestInitialize()
        {
            Console.WriteLine("Running UnitTest1 TestInitialize");
        }
        [TestCleanup]
        public  void TestCleanup()
        {
            Console.WriteLine("Running UnitTest1 TestCleanup");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Running UnitTest1 TestMethod1");
        }
        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("Running UnitTest1 TestMethod2");
        }
    }
}
