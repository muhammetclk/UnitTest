using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Asserts.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            const double girilenDeger = 16;
            const double beklenenDeger = 4;
            double gerceklesen = Math.Sqrt(girilenDeger);

            //bu sekilde tessten gecemezse kendi hata mesajimizi gösterebiliriz.
            Assert.AreEqual(beklenenDeger, gerceklesen, "{0} sayisinin karekoku {1} olmalidir.", girilenDeger, beklenenDeger);
        }
        [TestMethod]
        public void TestMethod2()
        {

            double beklenenDeger = 3.1622;
            //Formül: |beklenen-gerceklesen|<=delta
            double delta = 0.0001;
            double gerceklesen = Math.Sqrt(10);

            //bu sekilde (,) den sonraki kisim(162277 seklinde devam eden) delta degerinden kucukse testten gecer.
            Assert.AreEqual(beklenenDeger, gerceklesen, delta);

        }
        [TestMethod]
        public void TestMethod3()
        {

            string beklenenDeger = "MERHABA";

            string gerceklesen = "merhaba";

            //bu sekilde true yazarak buyuk kucuk harf duyarliligini ortadan kaldiriyoruz.
            Assert.AreEqual(beklenenDeger, gerceklesen, true);

        }
        [TestMethod]
        public void TestMethod4()
        {

            const double beklenmeyen = 0;//beklenmeyen degeri bularak testten gecme

            var gerceklesen = Math.Pow(5, 0);

            //AreNotEqual diyerek beklenmeyen degeri bularak tessten gecme yapabiliriz.
            Assert.AreNotEqual(beklenmeyen, gerceklesen);

        }
        [TestMethod]
        public void TestMethod5()
        {

            var sayilar = new byte[] { 1, 2, 3 };
            var digerSayilar = sayilar;
            sayilar[0] = 4;

            //AreSame degerlerin referanslarinin ayni olup olmamasiyla ilgilenir.
            //arrayler referans tipte oldugundan dolayı digerSayilar=sayilar ile adres atadik.
            //bu yuzden sayilar uzerinde yapacagim degisikli digerindede ayni sekilde degisir..
            //digerSayilari da newleyip degerlerini verseydik ozamn etkilemezdi.
            Assert.AreSame(sayilar, digerSayilar);

        }
        [TestMethod]
        public void TestMethod6()
        {
            int a = 10;
            int b = a;
            //burda int deger tipinde oldugu ıcın areEqual den gecer fakat AreSameden gecmez.                    
            // Assert.AreSame(a, b,"Are same fail oldu");
            Assert.AreEqual(a, b, "Are equal fail oldu.");
        }
        [TestMethod]
        public void TestMethod7()
        {

            Assert.AreEqual(1, 1);
            Assert.Inconclusive("Bu test yeterli degildir.");//test basarili fakat yeterli olmadigini belirtmek icin kulladnigimiz metod.
            //Run test yapinca unlem isareti cikar.

        }
        [TestMethod]
        public void TestMethod8()
        {

            var sayi = 5m;
            //verinin belirttigimiz tipte olup olmadigini kontrol ediyor.
            Assert.IsInstanceOfType(sayi, typeof(decimal));//decimaldir
            Assert.IsNotInstanceOfType(sayi, typeof(int));//int degildir tessten gecer.

        }
        [TestMethod]
        public void TestMethod9()
        {
            //dogrumu deilmi diye kontrol ediyor.
            Assert.IsTrue(10 % 2 == 0);
            Assert.IsFalse(10 % 5 == 1);
        }
        [TestMethod]
        public void TestMethod10()
        {
            List<string> Names = new List<string> { "Ahmet", "Mehmet", "Ali" };
            var cIleBaslayanIlkIsım = Names.FirstOrDefault(t => t.StartsWith("C"));
            var sIleBaslayanIlkIsım = Names.FirstOrDefault(t => t.StartsWith("A"));
            Assert.IsNull(cIleBaslayanIlkIsım,"IsNull basarisiz oldu");//FirstOrDefault esit degilse null atar.(Burda null olcak testten gecer)
            Assert.IsNotNull(sIleBaslayanIlkIsım,"IsNotNull basarisiz oldu.");//burda dolu gelir tessten gecer.(Acıklamalari hangisinde hata oldugunu ogrenmek ıcın yazdik.)
        }
        [TestMethod]
        public void TestMethod11()
        {
            try
            {
                var sayi1 = 5;
                int sonuc = sayi1 / 0;
            }
            catch (DivideByZeroException)
            {
                //testin basarisiz olmasini saglar.
                Assert.Fail("Test basarisiz oldu.");
            }
        }



    }
}
