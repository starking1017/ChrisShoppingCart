using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models.Cart
{
    [Serializable]
    public class CartItem
    {

        public int Id { get; set; }


        public string Name { get; set; }


        public decimal Price { get; set; }

        [RegularExpression("[0-9]{1,}")]
        public int Quantity { get; set; }


        public decimal Amount
        {
            get
            {
                return this.Price * this.Quantity;
            }
        }

        public string DefaultImageURL { get; set; }
    }
}
