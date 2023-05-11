using Demo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace DemoTests
{
    //once test yazilan gelistirmew sekli.
    //elimizde bir liste var ve en yuksek ve en dusuk sıcakliklari tutuyor.
    //Bu kisim red kismi testin yazildigi ve buil edildigi.
    //2. kisim green kismi .Testi gececek en basit kod.

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var olcumler = new List<Olcum>()//Olcum tipinde bir liste.
            {
                new Olcum//sıcaklik degerlerini tutuyor.
                {
                    enYuksek=10,
                    enDusuk=1

                }
            };
            var gruplayici = new Gruplayici(1);//yeni bir nesne olusturdum ve ctor ile 1 er sekilde gruplamasini istedik.
            var gruplar = gruplayici.Grupla(olcumler);//Gruplayici nesnesinde bir grupla metodu oldugunu dusunduk ve olcumler ile gittik.

            Assert.AreEqual(1, gruplar.Count);
        }
    }
}
