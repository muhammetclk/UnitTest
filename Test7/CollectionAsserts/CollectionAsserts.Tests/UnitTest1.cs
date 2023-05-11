using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionAsserts.Tests
{
    [TestClass]
    public class UnitTest1
    {
        //koleksiyon verilerini karsilastirmamiz gereken durumlarda CoolectionAssert kullanilir.

        private List<string> _kullanicilar;

        [TestInitialize]
        public void DataOlustur()
        {
            _kullanicilar = new List<string>();
            _kullanicilar.Add("Ahmet");
            _kullanicilar.Add("Mehmet");
            _kullanicilar.Add("Ali");
            



        }
        [TestMethod]
        public void Elemanlar_ve_Sirasi_Ayni_Olmalidir()
        {
            List<string> yeniKullanicilar = new List<string>();
            yeniKullanicilar.Add("Ahmet");
            yeniKullanicilar.Add("Mehmet");
            yeniKullanicilar.Add("Ali");
            //Bu test icin elemanlar ve sirasi ayni olmalidir.
            CollectionAssert.AreEqual(_kullanicilar, yeniKullanicilar);
        }
        [TestMethod]
        public void Elemanlar_ayni_Fakat_Sirasi_Farkli_Olabilir()
        {
            List<string> yeniKullanicilar = new List<string>();
            yeniKullanicilar.Add("Mehmet");
            yeniKullanicilar.Add("Ahmet");           
            yeniKullanicilar.Add("Ali");
            //bu test icin elamnlar ayni fakat sirasi farkli olabilir.
            CollectionAssert.AreEquivalent(_kullanicilar, yeniKullanicilar);
        }
        [TestMethod]
        public void Elemanlar_ve_Sirasi_ayni_Olmamalidir()
        {
            List<string> yeniKullanicilar = new List<string>();
            yeniKullanicilar.Add("Mehmet");
            yeniKullanicilar.Add("Ahmet");
            yeniKullanicilar.Add("Ali");
           //ilk initialize durumu disaindakiler olmali
            CollectionAssert.AreNotEqual(_kullanicilar, yeniKullanicilar);
        }
        [TestMethod]
        public void Elemanlar_Farkli_Olmalidir()
        {
            List<string> yeniKullanicilar = new List<string>();
            yeniKullanicilar.Add("Mehmet");
            yeniKullanicilar.Add("Ahmet");
            yeniKullanicilar.Add("A");
            //suan elamanlar ayni oldugu icin test basarisiz oldu.
            //bir urunun degistirmek yada yeni urun eklemek yeterli olacaktir.
            CollectionAssert.AreNotEquivalent(_kullanicilar, yeniKullanicilar);
        }
        [TestMethod]
        public void kullanicilar_Null_deger_Almamalidir()
        {
            //null deger varsa test basarisiz olur.
            CollectionAssert.AllItemsAreNotNull(_kullanicilar);
        }
        [TestMethod]
        public void kullanicilar_Benzersiz_olmalidir()
        {
            //ayni deger varsa test basarisiz olur.
            CollectionAssert.AllItemsAreUnique(_kullanicilar);
        }
        [TestMethod]
        public void Tüm_Kullaicilar_Ayni_tipte_olmalidir()
        {
            ArrayList list = new ArrayList { 3, 4, 5 };
            //farkli tip varsa test basarisiz olur.
            CollectionAssert.AllItemsAreInstancesOfType(list,typeof(int));
        }
        [TestMethod]
        public void IsSubsetOf_test()
        {
            List<string> yeniKullanicilar = new List<string> { "Ahmet", "Mehmet" };
            List<string> eskiKullanicilar = new List<string> { "Ahmet", "Hakan" };
            //bir listenin baska bir listenin kumesi olup olmadigini kontrol ediyor.
            CollectionAssert.IsSubsetOf(yeniKullanicilar, _kullanicilar);
            CollectionAssert.IsNotSubsetOf(eskiKullanicilar, _kullanicilar);
        }
        [TestMethod]
        public void Contains_test()
        {
            //Kontrol ediyor varmi diye
            CollectionAssert.Contains(_kullanicilar, "Ahmet");
            CollectionAssert.DoesNotContain(_kullanicilar, "Hakan");
        }

    }
}
