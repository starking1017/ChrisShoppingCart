using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models.Cart
{
    public class Ship
    {
        /// <summary>
        /// Receiver Name
        /// </summary>
        [Required]
        [Display(Name = "Receiver Name")]
        [StringLength(30, ErrorMessage = "{0}'s length must be {2} characters."
            , MinimumLength = 2)] 
        public string ReceiverName { get; set; }

        /// <summary>
        /// Receiver Phone
        /// </summary>
        [Required]
        [Display(Name = "Receiver Phone")]
        [StringLength(15, ErrorMessage = "{0}'s length must be {2} characters."
            , MinimumLength = 8)]
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// Receiver Address
        /// </summary>
        [Required]
        [Display(Name = "Receiver Address")]
        [StringLength(256, ErrorMessage = "{0}'s length must be {2} characters."
            , MinimumLength = 8)] 
        public string ReceiverAddress { get; set; }

    }
}
