using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountСalculator
{
    class Sum: IDiscount
    {
        public int DiscountSum { get; set; }
        public void GetInfo()
        {
            Console.WriteLine("Введите сумму скидки");
            int.TryParse(Console.ReadLine(), out var discountSum);
            DiscountSum = discountSum;
        }
        public int CalculatedDiscountPrice(int price)
        {
            return price - DiscountSum;
        }
    }
}
