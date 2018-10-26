using System;

namespace DiscountСalculator
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public IDiscount Discount { get; set; }

        
        public int CalculateDiscountPrice() 
        {
            return Discount.CalculatedDiscountPrice(Price);
        }


    }        
}
