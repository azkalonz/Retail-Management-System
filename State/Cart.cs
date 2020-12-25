using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Retail_Management_System.Models;
using Retail_Management_System.Screens;

namespace Retail_Management_System.State
{
    class Cart
    {
        public static List<Product> list = new List<Product>();
        public static float Total = 0;
        public static int TotalItems = 0;
        public static int AddToCart(Product product, int quantity)
        {
            product.CartQuantity = quantity;
            product.CartID = list.Count + 1;
            Cart.Total += product.Price* product.CartQuantity;
            list.Add(product);
            Cart.TotalItems += 1;
            return product.CartID;
        }
        public static void RemoveToCart(Product product)
        {
            Cart.Total -= product.CartQuantity * product.Price;
            Cart.TotalItems -= 1;
            list.Remove(product);
        }
        public static void Checkout(Action callback
        )
        {
            ClearCart();
            Success form = new Success();
            form.ShowDialog();
            callback();
        }
        public static void ClearCart()
        {
            list.Clear();
            Total = 0;
            TotalItems = 0;
        }
    }
}
