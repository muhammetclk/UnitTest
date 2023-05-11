using ShoppingCart;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartTests
{
    //gereksinimlerimiz degisti ayni urunden eklenince hata mesaji vaermeli.
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
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]//bekledigimiz hata turunu veriyoruz.(yolladigimiz hata tipi .Birebir hataya bakiyor.)
        //[ExpectedException(typeof(Exception),AllowDerivedTypes =true)]//Turetilmis bir tipten yapacaksak AllowDerivedTypes =true diyerek turemis tiplere izin vermeliyiz.
        public void Sepete_ayni_urunden_eklendiginde_hata_vermelidir()
        {

            //method calisiyor(Hatayi gosteriyor) ama test basarısiz oluyor..(Bu islemi teste ogretmeliyiz.)
            //kullaniciya hatayi gostermesiylede testin basarili oldugunu ogreticez.
            //Bunuda ExceptedException attribute ile yapıyoruz.
            _cartManager.Add(_cartItem);//ekleme islemi(Ayni urunu ekliyoruz.)

        }


    }
}
