using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestAttributes1.Tests
{
    //owner attributesi test motodunun sahibini belirtir.
    //owner ile sadece bir kisinin yazdigi  testleri calistirabiliriz.
    //TestCategory attribute testleri gruplamak icin kullanilir.
    //Priority attribute oncelik belirtmek icin kullanilir.(Bazi testler uzun surer oncelik belirtebilriz.)
    //TestPreporty spesifik bir durama gore gruplamada kullacagimiz attribute
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [Owner("Ahmet")]
        [TestCategory("Tester")]
        [Priority(1)]
        [TestProperty("Guncelleyen","Mehmet")]//Testi ahmet yazmis fakat Mehmet testi guncellemis anlaminda.
        [TestProperty("Guncelleyen2", "Mehmet")]//Birden fazla kullanabilriz ama mesaji degistirmeliyiz.
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }
        [Owner("Mehmet")]
        [TestMethod]
        [TestCategory("Tester")]
        [Priority(2)]
        public void TestMethod2()
        {
            Assert.AreEqual(1, 1);
        }
        [Owner("Ali")]
        [TestMethod]
        [TestCategory("Developer")]
        [TestCategory("Tester")]
        [TestCategory("Demo")]
        [Priority(1)]
        public void TestMethod3()
        {
            Assert.AreEqual(1, 1);
        }
        [Owner("Ayse")]
        [TestMethod]
        [TestCategory("Tester")]
        [Priority(3)]
        public void TestMethod4()
        {
            Assert.AreEqual(1, 1);
        }
        [Owner("Fatma")]
        [TestCategory("Developer")]
        [TestMethod]
        [Priority(2)]
        public void TestMethod5()
        {
            Assert.AreEqual(1, 1);
        }
    }

}
