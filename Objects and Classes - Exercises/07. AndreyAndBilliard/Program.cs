using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AndreyAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var entities = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                var entity = Console.ReadLine()
                .Split('-').ToArray();

                string product = entity[0];
                double price = double.Parse(entity[1]);
                entities[product] = price;
            }

            string client = "";
            List<ClassClient> clients = new List<ClassClient>();

            while (client != "end of clients") 
            {
                client = Console.ReadLine();
                
                if (client != "end of clients")
                {
                    var input = client.Split(new char[] { '-', ',' })
                .ToArray();
                    if (entities.ContainsKey(input[1]))
                    {
                        var cl = new ClassClient();

                        cl.Name = input[0];
                        cl.Product = input[1];
                        cl.Number = int.Parse(input[2]);
                        clients.Add(cl);

                    }
                }
            }

            var total = 0.0;

                foreach (var cl in clients.OrderBy(c => c.Name))
                {
                    Console.WriteLine(cl.Name);
                    Console.WriteLine($"-- {cl.Product} - {cl.Number}");
                    var bill = cl.Number * entities[cl.Product];

                    total += bill;

                    Console.WriteLine($"Bill: {bill:f2}");
                }
                Console.WriteLine($"Total bill: {total:f2}");
        }
    }

    class ClassClient
    {
        public string Name { get; set; }
        public string Product { get; set; }
        public int Number { get; set; }
    }

}
