using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountСalculator
{
    class DiscountCard: IDiscount
    {
        public int Sum { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public void GetInfo() 
        {
            Console.WriteLine("Введите сумму скидки");
            int.TryParse(Console.ReadLine(), out var sum);
            Console.WriteLine("Введите дату начала действия скидочной карты");
            DateTime.TryParse(Console.ReadLine(), out var start);
            Console.WriteLine("Введите дату оконачания действия скидочной карты");
            DateTime.TryParse(Console.ReadLine(), out var end);
            Start = start;
            End = end;
            Sum = sum;

        }
        public int CalculatedDiscountPrice(int price)
        {
            if (DateTime.Today < End)
            {
                return price - Sum;
            }
            else
            {
                Console.WriteLine("Срок действия карты истек");
                return price;
            }
        }
        
    }
}
