using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Tests
{
    [TestClass]
     public class StringHelperTests
    {
        //Gereksinim ismi neyse metod o olacak.
        [TestMethod]
        public void Girilen_ifadenin_basindaki_ve_sonundaki_fazla_bosluklar_silinmelidir()
        {
            //Arrange kismi
            var ifade ="   Muhammet Celik   ";
            var beklenen ="Muhammet Celik";

            //Act kismi
            var gerceklesen = StringHelper.FazlaBosluklariSil(ifade);

            //Assert kismi
            Assert.AreEqual(beklenen, gerceklesen);//beklenen ile gerceklesen esitse test dogrudur.
        }
        [TestMethod]
        public void Girilen_ifadenin_icindeki_fazla_bosluklar_silinmelidir()
        {
            //Arrange kismi
            var ifade = "Muhammet Celik  Ahmet    Mehmet   Ali ";
            var beklenen = "Muhammet Celik Ahmet Mehmet Ali";

            //Act kismi
            var gerceklesen = StringHelper.FazlaBosluklariSil(ifade);

            //Assert kismi
            Assert.AreEqual(beklenen, gerceklesen);//beklenen ile gerceklesen esitse test dogrudur.
        }
    }
}
