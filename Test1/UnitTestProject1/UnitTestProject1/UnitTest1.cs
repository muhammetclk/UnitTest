using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
    //Bir birim testi 3 asamadan olusur.(3 A paternide denir.)
    //1.kısım arrange kismi.Hazirliklarimizi yaptigimiz kisim.İhtiyacimiz olan degiskenleri tanimladigimiz kisim.
    //2.Kisim Act kismi.Eyleme gectigimiz kisim.Test etmek istedigimiz fonksiyonun işlevini cagirdigimiz ve gerceklesen sonucu aldigimiz kisim.
    //3.Kısım Assert kismi.Tesitimizin gecerli olup olmadigini belirleyen kisim.
{
    [TestClass]//Test classı olmasi icin [TestClass] attirubute den faydalaniyoruz.
    public class UnitTest1
    {
        [TestMethod]//Test method olmasi icin [TestMethod] attirubute den faydalaniyoruz.
        public void TestMethod1()
        {
        }
    }
}
