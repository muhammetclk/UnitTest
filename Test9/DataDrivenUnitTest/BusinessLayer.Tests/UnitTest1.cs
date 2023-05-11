using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BusinessLayer.Tests
{
    //bu test xml deki her satir icin calismali bu yuzden testimizi birim temelli halee getirmeliyiz.
    //Bunun icin datasorce attribute kullaniyoruz.

    
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }//TEstContext ile xmldeki ad,tel,emaile ulasicaz.

        //providername veriyoruz xml ile calisicaz.
        //Connectıonstrıngi veriyoruz dosyanin yolu.(dosyanin properties kismindan copy always yapmaliyiz.( bin- debug kismina ekleme yapar.)
        //Tablo adini veriyoruz xml dosyasindaki verilerin basinda yazan(Kullanici)
        //DataAccesMethod.Sequntial diyerek sirali bir sekilde veriyoruz.
        //
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
        "Kullanicilar2.xml",
        "Kullanici",DataAccessMethod.Sequential)]
        [TestMethod]
        public void DataTest()//bu test xmldeki her satir icin calisicak.
        {  
            var manager = new KullaniciManager();
            var ad = TestContext.DataRow["ad"].ToString();
            var telefon = TestContext.DataRow["telefon"].ToString();
            var mail = TestContext.DataRow["mail"].ToString();

            
            var sonuc = manager.KullaniciEkle(ad,telefon,mail);
            Assert.IsTrue(sonuc);
        }
    }
}
