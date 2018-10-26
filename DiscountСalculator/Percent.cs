using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountСalculator
{
    class Percent: IDiscount
    {
        public int DiscountPercent { get; set; }
        public void GetInfo()
        {
            Console.WriteLine("Введите процент скидки");
            int.TryParse(Console.ReadLine(), out var discountPercent);
            DiscountPercent = discountPercent;
        }
        public int CalculatedDiscountPrice(int price)
        {
            return price - price / 100 * DiscountPercent;
        }
    }
}
