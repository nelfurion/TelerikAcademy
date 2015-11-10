namespace LargeTradeCompany
{
    using System;
    using Wintellect.PowerCollections;

    class LargeTradeCompany
    {
        static void Main(string[] args)
        {
            OrderedMultiDictionary<decimal, Article> articles = new OrderedMultiDictionary<decimal, Article>(false);

            Random rand = new Random();

            for (int i = 0; i < 1000; i++)
            {
                decimal price = rand.Next(10, 50);
                articles.Add(price, new Article("foo", "bar", "foobar", price));
            }

            foreach (var article in articles.Range(20M, true, 40M, true))
            {
                Console.WriteLine(article.ToString());
            }
        }
    }
}
