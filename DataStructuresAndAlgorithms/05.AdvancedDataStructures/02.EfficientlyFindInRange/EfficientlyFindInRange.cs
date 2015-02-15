namespace EfficientlyFindInRange
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Wintellect.PowerCollections;

    class EfficientlyFindInRange
    {
        //02.Write a program to read a large collection of products (name + price) and efficiently find
        //  the first 20 products in the price range [a…b]. Test for 500 000 products and 10 000 price 
        //  searches.
        //  Hint: you may use OrderedBag<T> and sub-ranges.

        private static readonly Random getrandom = new Random();
        private static readonly object syncLock = new object();

        static void Main()
        {

            OrderedBag<Product> products = new OrderedBag<Product>();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 1; i <= 500000; i++)
            {
                var name = "Prod" + i;
                var price = GetRandomNumber(35, 599) * i * GetRandomNumber(3, 5) / GetRandomNumber(2, 4);
                Product p = new Product(name, price);

                products.Add(p);
            }

            stopwatch.Stop();
            Console.WriteLine("Create and add 500k Products: {0}", stopwatch.Elapsed);

            List<Product> prodRange = new List<Product>();
            stopwatch.Reset();
            stopwatch.Restart();

            for (int i = 1; i <= 10000; i++)
            {
                int min = GetRandomNumber(10, 1000) * i * GetRandomNumber(3, 5) / GetRandomNumber(2, 4);
                int max = GetRandomNumber(10, 1000) * i << 1 * GetRandomNumber(3, 5);
                prodRange.AddRange(products.Range(new Product() { Price = min }, true, new Product() { Price = max }, true).Take(20));
            }

            stopwatch.Stop();

            Console.WriteLine("Search for 10k random price ranges: {0}", stopwatch.Elapsed);
        }

        public static int GetRandomNumber(int min, int max)
        {
            lock (syncLock)
            { 
                return getrandom.Next(min, max);
            }
        }
    }
}
