using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartTests
{
    //ClassInitialize nin TestInitialize attribute den farki ilk ve son  calismasi olmasidir.
    //TestInitialize de her birim testinden once calisiyordu.
    //burda ise ilk calisiyor ve daha sonra birim testlerin hepsi calisiyor.
    //ClassInitialize de dikkat edilmesi gereken static tanimlanmasi ve TestContext tipinde parametre almasi.


    [TestClass]
    public class CartTests
    {
        private static CartManager _cartManager;
        private static CartItem _cartItem;
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            _cartManager = new CartManager();
            _cartItem = new CartItem
            {
                Product = new Product
                { ProductId = 1, ProductName = "Laptop", UnitPrice = 25 },
                Quantity = 1
            };
            _cartManager.Add(_cartItem);
        }
        [ClassCleanup]
        public static void TestCleanUp()
        {
            _cartManager.Clear();
        }

        [TestMethod]
        public void Sepette_olan_urunden_1_adet_eklendiginde_sepetteki_toplam_urun_adedi_1_artmali_eleman_sayisi_ayni_kalmalidir()
        {
            //Arrange
            int toplamAdet = _cartManager.TotalQuantity;//once sepeeteki urun adedini almisiz.
            int toplamElemanSayisi = _cartManager.TotalItems;//sepetteki eleman sayisini almisiz
            //act
            
            _cartManager.Add(_cartItem);//ekleme islemi(Ayni urunu ekliyoruz.)
            //assert
            Assert.AreEqual(toplamAdet+1 , _cartManager.TotalQuantity);//aldıgımız toplam urunun adedinin bir fazlasini karsiastirmisiz.
            Assert.AreEqual(toplamElemanSayisi , _cartManager.TotalItems);//aldigimiz urunun eleman sayiisinin aynısını karsilastirimisiz.


        }
        [TestMethod]
        public void sepete_farkli_urunde_1_adet_eklendiginde_sepetteki_toplam_urun_adedi_1_artmali_eleman_sayısı_1_artmali()
        {
            //Arrange
            int toplamAdet = _cartManager.TotalQuantity;//once sepeeteki urun adedini almisiz.
            int toplamElemanSayisi = _cartManager.TotalItems;//sepetteki eleman sayisini almisiz
            //act
            _cartManager.Add(new CartItem//yeni farkli bir urun ekledik.
            {
                Product = new Product { ProductId = 2, ProductName = "GSM", UnitPrice = 5000 },
                Quantity = 1

            });
            
            //assert
            Assert.AreEqual(toplamAdet + 1, _cartManager.TotalQuantity);//aldıgımız toplam urunun adedinin bir fazlasini karsiastirmisiz.
            Assert.AreEqual(toplamElemanSayisi + 1, _cartManager.TotalItems);//aldigimiz urunun eleman sayiisinin 1 fazlasini karsilastirimisiz.


        }              
    }
}
