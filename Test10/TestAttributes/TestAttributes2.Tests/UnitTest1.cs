using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

namespace TestAttributes2.Tests
{
    //Ignore attribute bir tesi pas gecmek icibn kullanilir.(Testi yapmaz)
    //TimeOut attribute test icin timeout suresi verir.(ms cinsinde 1000 ms =1 sn)
    //Description aciklama icin kullanilir.

    [TestClass]
    public class UnitTest1
    {



        [TestMethod,Timeout(1000)]//Eger test1 in calisma suresi 1 sn nin uzerine cikarsa timeouta girer ve test failed olur.
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }
        [TestMethod,Timeout(1000)]
        public void TestMethod2()
        {
            Thread.Sleep(1500);//sistemi 1500 ms uyutur ve testimizin suresini asacagi icin test basarisiz olur.
            Assert.AreEqual(1, 1);
        }
        [TestMethod,Timeout(TestTimeout.Infinite)]//int tipinin maksimum degerini verir.
        [Description("Bu bir karekok islemi testi  yapan metoddur.")]
        public void TestMethod3()
        {
            Assert.AreEqual(1, 1);
        }
        [TestMethod]
        [Ignore]
        public void TestMethod4()
        {
            Assert.AreEqual(1, 1);
        }
        [TestMethod]
        [Ignore]
        public void TestMethod5()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
