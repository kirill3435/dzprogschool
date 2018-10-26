using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountСalculator
{
    public interface IDiscount
       
    {
        void GetInfo();
        int CalculatedDiscountPrice(int price);
    }
}
