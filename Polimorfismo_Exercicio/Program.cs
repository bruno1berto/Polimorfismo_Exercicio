using Polimorfismo_Exercicio.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Polimorfismo_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Commun, Used, Imported (C,U or I): ");
                char type = char.Parse(Console.ReadLine());
                while (type != 'C' && type != 'c' && type != 'U' && type != 'u' && type != 'I' && type != 'i')
                {
                    Console.Write("Latter invalid. Press (C, U or I): ");
                    type = char.Parse(Console.ReadLine());
                }
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: $ ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (type == 'C' || type == 'c')
                {
                    products.Add(new Product(name, price));
                } else if (type == 'U' || type == 'u')
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufactureDate));
                }else if (type == 'I' || type == 'i')
                {
                    Console.Write("Customs Fee: $ ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customsFee));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAG's");
            foreach (Product prod in products)
            {
                Console.WriteLine(prod.PriceTag());
            }
            Console.ReadLine();
        }
    }
}
