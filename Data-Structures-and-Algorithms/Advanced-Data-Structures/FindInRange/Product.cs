/*
Write a program to read a large collection of products (name + price) and efficiently find the first 20 products in the price range [a…b].
Test for 500 000 products and 10 000 price searches.
Hint: you may use OrderedBag<T> and sub-ranges.
*/
namespace FindInRange
{
    using System;

    class Product : IComparable<Product>
    {
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name
        {
            get;
            set;
        }

        public decimal Price
        {
            get;
            set;
        }

        public int CompareTo(Product other)
        {
            if (this.Price > other.Price)
            {
                return 1;
            }
            else if (this.Price == other.Price)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
