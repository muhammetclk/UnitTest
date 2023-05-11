using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartTests
{
    [TestClass]
    public class CartTests
    {
        private CartManager _cartManager;
        private CartItem _cartItem;
        [TestInitialize]//her test metodunda urun eklemesi yapiliyodu.TestInitialize attribute ile ilk bu metod calisiyor.Ve urun ekleme islemini yapiyor.
        public void TestInitialize()//lk calisan ve urun ekliyen metod.
        {
            _cartManager = new CartManager();
            _cartItem = new CartItem//yeni bir urun ekledik.
            {
                Product = new Product
                { ProductId = 1, ProductName = "Laptop", UnitPrice = 25 },
                Quantity = 1
            };           
            _cartManager.Add(_cartItem);
        }
        public void TestCleanUp()//Test mothodlarindan sonra calisir.
        {
            _cartManager.Clear();//islemlerden sonra sepeti temizle gibi.
        }
        [TestMethod]
        public void Sepete_urun_eklenebilmelidir()
        {
            //Arrange kismi
            int beklenen = 1;//sepete 1 tane urun ekicez.
            
            //act kismi
            var ToplamElemanSayisi = _cartManager.TotalItems;

            //Assert kismi
            Assert.AreEqual(beklenen, ToplamElemanSayisi);//1 urun eklemistik Toplam eleman sayisi ile esitmi diye kontrol ettik.

        }
        [TestMethod]
        public void Sepette_olan_urun_cikarilabilmelidir()//cıkarilmasi icin once urun olmali
        {           
            var SepetteOlanElemanSayisi =_cartManager.TotalItems;//urun ekledik ve seppte olan eleman sayisini bulduk.
           _cartManager.Remove(1);//septten urun sildik.
            var SepetteKalanElemanSayisi =_cartManager.TotalItems;//sepette kalan eleman sayisini bulduk.
            //Assert kismi
            Assert.AreEqual(SepetteOlanElemanSayisi - 1, SepetteKalanElemanSayisi);//sepette olanin 1 eksigi esitmi sapette kalan ile .
        }
        [TestMethod]
        public void Sepet_Temizlenebilmelidir()
        {
            
            //Act kismi
           _cartManager.Clear();//septeti temizledik.

            //Assert kismi
            Assert.AreEqual(0,_cartManager.TotalItems);
            Assert.AreEqual(0,_cartManager.TotalQuantity);
        }
    }
}
