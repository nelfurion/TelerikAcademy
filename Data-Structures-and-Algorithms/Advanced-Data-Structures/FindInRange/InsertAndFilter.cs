namespace FindInRange
{
    using System;
    using System.Text;
    using Wintellect.PowerCollections;

    class InsertAndFilter
    {
        static void Main(string[] args)
        {
            OrderedBag<Product> products = new OrderedBag<Product>();
            Console.WriteLine(int.MaxValue);
            Random random = new Random();

            Fill(products, random);
            Filter(products, random);
        }

        static string GetRandomString(Random random, int size)
        {
            StringBuilder builder = new StringBuilder();

            char next;
            for (int i = 0; i < size; i++)
            {
                next = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(next);
            }

            return builder.ToString();
        }

        static void Fill(OrderedBag<Product> bag, Random random)
        {
            Console.WriteLine("Inserting...");

            for (int i = 0; i < 500000; i++)
            {
                Product next = new Product(GetRandomString(random, 5), random.Next(3000, 10000));
                bag.Add(next);
            }

            Console.WriteLine("Done!");
        }

        static void Filter(OrderedBag<Product> bag, Random random)
        {
            Console.WriteLine("Filtering by price...");

            for (int i = 0; i < 10000; i++)
            {
                Product from = new Product("", random.Next(3000, 3050));
                Product to = new Product("", random.Next(9950, 10000));

                bag.Range(from, true, to, true);
            }

            Console.WriteLine("Done!");
        }
    }
}
