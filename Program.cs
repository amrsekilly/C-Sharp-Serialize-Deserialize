using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an object from class Product
            var prod1 = new Product {
                ID = 12,
                Name = "iPhone10",
                Price = 1240.99 };
        }
    }

    // create a product class
    class Product {
        public int ID {get; set;}
        public string Name {get; set;}
        public double Price {get; set;}
    }
}


