using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var sales = new SortedDictionary<string, double>();
            for (int i = 0; i < count; i++)
            {
                Sale sale = new Sale();
                sale = sale.ReadSale();
                if (sales.ContainsKey(sale.Town))
                {
                    sales[sale.Town] += (sale.Quantity * sale.Price);
                }
                else
                {
                    sales[sale.Town] = sale.Quantity * sale.Price;
                }
            }
            foreach ( var sale in sales)
            {
                Console.WriteLine($"{sale.Key:f2} -> {sale.Value:f2}");
            }
        }
    }

    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        internal Sale ReadSale()
        {

            string[] saleData = Console.ReadLine()
                .Split().ToArray();
            Sale sale = new Sale()
            {
                Town = saleData[0],
                Product = saleData[1],
                Price = double.Parse(saleData[2]),
                Quantity = double.Parse(saleData[3])
            };
            return sale;  
        }
    }
}
