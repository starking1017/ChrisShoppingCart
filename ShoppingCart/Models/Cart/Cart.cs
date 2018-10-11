using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using ShoppingCart.Data;
using ShoppingCart.Repositories;

namespace ShoppingCart.Models.Cart
{
    [Serializable]
    [JsonObject]
    public class Cart : IEnumerable<CartItem>
    {

        public Cart()
        {
            this.Items = new List<CartItem>();
        }

        public List<CartItem> Items { get; set; }
        /// <summary>
        /// total amount of cart
        /// </summary>
        public int Count
        {
            get
            {
                return this.Items.Count;
            }
        }

        //Get total amount
        public decimal TotalAmount
        {
            get
            {
                decimal totalAmount = 0.0m;

                foreach (var item in Items)
                {
                    totalAmount = totalAmount + item.Amount;
                }
                return totalAmount;
            }
        }


        public bool AddProduct(ApplicationDbContext pContext , int pProductId)
        {
            var findItem = this.Items.FirstOrDefault(pCart => pCart.Id == pProductId);

            if (findItem == default(CartItem))
            {  
                var product = pContext.Products.FirstOrDefault(s => s.Id == pProductId);

                if (product != default(Product.Product))
                {
                    this.AddProduct(product);
                }
            }
            else
            {   
                findItem.Quantity += 1;
            }
            return true;
        }

        private bool AddProduct(Product.Product pProduct)
        {
            var cartItem = new Models.Cart.CartItem()
            {
                Id = pProduct.Id,
                Name = pProduct.Name,
                Price = pProduct.Price,
                DefaultImageURL = pProduct.DefaultImageURL,
                Quantity = 1
            };

            this.Items.Add(cartItem);
            return true;
        }

        public bool RemoveProduct(int ProductId)
        {
            var findItem = this.Items
                            .Where(s => s.Id == ProductId)
                            .Select(s => s)
                            .FirstOrDefault();

            if (findItem == default(CartItem))
            {
                // not in the cart do nothing
            }
            else
            {   
                this.Items.Remove(findItem);
            }
            return true;
        }

        // Clear Cart
        public bool ClearCart()
        {
            this.Items.Clear();
            return true;
        }

        // cartItem to OrderDetail list
        public List<OrderDetail> ToOrderDetailList(int orderId)
        {
            var result = new List<OrderDetail>();
            foreach (var cartItem in this.Items)
            {
                result.Add(new OrderDetail()
                {
                    Name = cartItem.Name,
                    Price = cartItem.Price,
                    Quantity = cartItem.Quantity,
                    OrderId = orderId
                });
            }
            return result;
        }


        #region IEnumerator

        public IEnumerator GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        IEnumerator<CartItem> IEnumerable<CartItem>.GetEnumerator()
        {
            return Items.GetEnumerator();
        }
        #endregion
    }
}
