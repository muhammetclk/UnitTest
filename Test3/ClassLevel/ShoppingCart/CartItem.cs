using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    //sepete ekleyecegimiz urun ve kac adet ekleyecegimiz.
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
