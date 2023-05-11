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
    //4. Sepete ayni urunden eklendiginde hata vermelidir.
    //5. sepete farkli urunde 1 adet eklendiginde sepetteki toplam urun adedi 1 artmali eleman sayısı 1 artmali.

    public class CartManager
    {
        
        private readonly List<CartItem> _cartItems;

        
        public CartManager()
        {
            _cartItems = new List<CartItem>();
        }

        
        public void Add(CartItem cartItem)
        {
            //eklenen urun ile sapetteki urun ıd si esitmi kontrol ettik.
            var addedCartItems = _cartItems.SingleOrDefault(t => t.Product.ProductId == cartItem.Product.ProductId);
            if (addedCartItems == null)//esit degilse yeni urun eklicek.
            {
                _cartItems.Add(cartItem);
            }
            else//aynı urunden eklerse bu hata mesajini firlaticak.
            {
                throw new ArgumentException("Ayni urunden  sepette var.Ekleyemezsiniz");
            }

        }
        
        public void Remove(int productId)
        {
            var product = _cartItems.FirstOrDefault(t => t.Product.ProductId == productId);
            _cartItems.Remove(product);
        }
        
        public List<CartItem> CartItems
        {
            get
            {
                return _cartItems;
            }
        }
        
        public void Clear()
        {
            _cartItems.Clear();
        }
        
        public decimal TotalPrice
        {
            get { return _cartItems.Sum(t => t.Product.UnitPrice * t.Quantity); }
        }
        
        public int TotalQuantity
        {
            get { return _cartItems.Sum(t => t.Quantity); }
        }
        
        public int TotalItems { get { return _cartItems.Count; } }
    }
}
