using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    //gereksinimler
    //1. Sepete urun eklenebilmelidir.
    //2. Sepette olan urun cikarilabilmelidir.
    //3. Sepet Temizlenebilmelidir.
    //4. Sepette olan urunden 1 adet eklendiginde sepetteki  toplam urun adedi 1 artmali eleman sayisi ayni kalmalidir.
    //5. sepete farkli urunde 1 adet eklendiginde sepetteki toplam urun adedi 1 artmali eleman sayısı 1 artmali.
    public class CartManager
    {
        //urunleri tutacagimiz liste.
        private readonly List<CartItem> _cartItems;

        //ctor ile newledik.
        public CartManager()
        {
            _cartItems = new List<CartItem>();
        }

        //listemize(sepetimize) urun ekliyor.
        public void Add(CartItem cartItem)
        {
            //eklenen urun ile sapetteki urun ıd si esitmi kontrol ettik.
            var addedCartItems = _cartItems.SingleOrDefault(t => t.Product.ProductId == cartItem.Product.ProductId);
            if (addedCartItems == null)//esit degilse yeni urun eklicek.
            {
                _cartItems.Add(cartItem);
            }
            else//esitse ayni urunun adedini girilen addet kadar arttiricak.
            {
                addedCartItems.Quantity += cartItem.Quantity;
            }
            
        }
        //sepetimizdeki urunu Id sine gore siliyor.
        public void Remove(int productId)
        {
            var product = _cartItems.FirstOrDefault(t => t.Product.ProductId == productId);
            _cartItems.Remove(product);
        }
        //sepetteki urunleri listeliyor.
        public List<CartItem> CartItems
        {
            get
            {
                return _cartItems;
            }
        }
        //sepetimizi temizliyor.
        public void Clear()
        {
            _cartItems.Clear();
        }
        //sepetteki urunlerin toplam fiyatini getiriyor.
        public decimal TotalPrice
        {
            get { return _cartItems.Sum(t => t.Product.UnitPrice * t.Quantity); }
        }
        //sepetteki toplam urun addedini getirir.
        public int TotalQuantity
        {
            get { return _cartItems.Sum(t => t.Quantity); }
        }
        //sepetteki eleman adedini getirir.
        public int TotalItems { get { return _cartItems.Count; } }
    }
}
