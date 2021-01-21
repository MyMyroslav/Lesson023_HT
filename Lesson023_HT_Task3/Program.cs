using System;

namespace Lesson023_HT_Task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Price[] prices = new Price[2];
            int i = 0;
            while (i < 2)
            {
                prices[i] = new Price();
                Console.WriteLine("Enter" + " " + i + " " + "name:");
                prices[i].name = Console.ReadLine();
                Console.WriteLine("Enter" + " " + i + " " + "price:");
                prices[i].price = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter" + " " + i + " " + "shop name:");
                prices[i].shop = Console.ReadLine();
                i++;
            }
            try
            {
                Console.WriteLine("Enter your shop:");
                string yourShop = Console.ReadLine();
                for (int z = 0; z < 2; z++)
                {
                    if (yourShop != prices[z].shop)
                    {
                        throw new Exception("not this shop!");
                    }
                    else
                    {
                        Console.WriteLine(prices[z].name);
                        Console.WriteLine(prices[z].price);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
            Array.Sort<Price>(prices, (x, y) => x.shop.CompareTo(y.shop));
            Console.WriteLine(prices[0].shop);
            Console.WriteLine(prices[1].shop);

        }

    }
}



