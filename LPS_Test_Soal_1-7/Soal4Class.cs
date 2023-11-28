using System;
using System.Collections.Generic;

namespace LPS_Test_Soal_1_7
{
    public class Product
    {
        public Product(string sku, decimal price)
        {
            SKU = sku;
            Price = price;
        }

        public string SKU { get; set; }
        public decimal Price { get; set; }
    }

    public class Soal4Class
    {
        public void RunMemoryLeakExample()
        {
            var myList = new List<Product>();

            while (true)
            {
                // Populate list with 1000 integers
                for (int i = 0; i < 1000; i++)
                {
                    myList.Add(new Product(Guid.NewGuid().ToString(), i));
                }

                // Do something with the list object
                Console.WriteLine(myList.Count);

                // Clear the list periodically to release memory
                if (DateTime.Now.Second % 10 == 0) // Clear the list every 10 seconds (adjust as needed)
                {
                    Console.WriteLine("Clearing the list...");
                    myList.Clear();
                }
            }
        }
    }
}
