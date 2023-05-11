using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestContextDemo.Test
{
    //TestContext, testimizdeki veriler hakkinda bilgi almamizi saglar.


    [TestClass]
    public class UnitTest1
    {
        //biz set etmicez runtimeda kendisi set oluyor.ismininde TestContext olmasi gerekiyor.
        public TestContext TestContext { get; set; }



        [TestInitialize]
        public void TestInitialize()
        {
            //istedigimiz herhangi bir bilgiyi output ekranina yazar.
            TestContext.WriteLine("--TestInitialize--");
            TestContext.WriteLine("Test Durumu:{0}", TestContext.CurrentTestOutcome);//testin durumunu verir.
            
            TestContext.Properties["Bilgi"]="Bu bir ekstra bilgidir.";//(key=bilgi)bu sekilde testimize atabiliriz.

        }

        [TestCleanup]
        public void TestCleanup()
        {
            //istedigimiz herhangi bir bilgiyi output ekranina yazar.
            TestContext.WriteLine("--TestCleanup--");            
            TestContext.WriteLine("Test Durumu:{0}", TestContext.CurrentTestOutcome);//testin durumunu verir.
            //testten gecip gecmedigini son olarak Cleanup da ogreniriz(output ekranindan)

            TestContext.WriteLine("Test Bilgi:{0}", TestContext.Properties["Bilgi"]);

        }
        [TestMethod]
        public void TestMethod1()
        {
            //istedigimiz herhangi bir bilgiyi output ekranina yazar.
            TestContext.WriteLine("--TestMethod1--");
            TestContext.WriteLine("Test Adı:{0}",TestContext.TestName);//testin adini verir.
            TestContext.WriteLine("Test Durumu:{0}", TestContext.CurrentTestOutcome);//testin durumunu verir.
            TestContext.WriteLine("Test class adi:{0}", TestContext.FullyQualifiedTestClassName);
            Assert.AreEqual(1, 1);
        }
    }
}
