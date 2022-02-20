using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class PriceQuotationModel
    {
        [Required(ErrorMessage = "Please enter a subtotal.")]
        [Range(.01, Double.PositiveInfinity, ErrorMessage = "Subtototal must be 1 cent or greater")]
        public decimal? Subtotal { get; set; }

        [Required(ErrorMessage = "Please enter a discount percent.")]
        [Range(1, 100, ErrorMessage = "Discount percent must be between 1 and 100.")]
        public decimal? DiscountPercent { get; set; }

        public decimal? CalculateDiscountAmount()
        {
            decimal? discountAmount = 0;
            discountAmount = (Subtotal * (DiscountPercent / 100));
            return discountAmount;
        }

        public decimal? CalculateTotal()
        {
            decimal? total = 0;
            total = Subtotal - CalculateDiscountAmount();
            return total;

        }

    }
}




