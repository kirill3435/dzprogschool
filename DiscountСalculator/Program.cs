using System;

namespace DiscountСalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вы хотите добавить новый продукт? 1 - да, 2 - нет");

            int.TryParse(Console.ReadLine(), out var answer);

            if (answer != 1)
                return;

            CreateProduct();

            Console.ReadLine();
        }

        private static void CreateProduct()
        {
            var product = new Product();

            Console.WriteLine("Введите название продукта");

            product.Name = Console.ReadLine();

            Console.WriteLine("Введите стоимость продукта");

            int.TryParse(Console.ReadLine(), out var price);

            while (price == 0)
            {
                Console.WriteLine("Стоимость продукта не была введена или она была введена с ошибкой. Пожалуйста, введите стоимость продукта ещё раз");

                int.TryParse(Console.ReadLine(), out price);
            }

            product.Price = price;
            Console.WriteLine("Выберите вид скидки: 1 - скидочная карта, 2 - процент от стоимости, 3 - сумма от стоимости");
            int.TryParse(Console.ReadLine(), out var discountType);
            switch (discountType)
            {
                case 1:

                     product.Discount = new DiscountCard(); 
                    break;
                case 2:

                     product.Discount = new Percent();
                    break;
                case 3:

                     product.Discount = new Sum();
                    break;

            }
            product.Discount.GetInfo();
            Console.WriteLine($"Вы успешно добавили новый продукт: {product.Name}, стоимость - {product.CalculateDiscountPrice()}р.");
        }
    }
}
