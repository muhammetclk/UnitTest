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
            _cartItems.Add(cartItem);
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
            get{ return _cartItems.Sum(t => t.Product.UnitPrice * t.Quantity); }
        }
        //sepetteki toplam urun addedini getirir.
        public decimal TotalQuantity
        {
            get { return _cartItems.Sum(t => t.Quantity); }
        }
        //sepetteki urun adedini getirir.
        public int TotalItems { get { return _cartItems.Count; } }

    }
}
