using System.Text;

namespace Polimorfismo_Exercicio.Entities
{
    class Product
    {
        public string Name { get; protected set; }
        public double Price { get; protected set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            string tag = Name + " $ " + Price.ToString("F2");
            return tag;
        }
    }
}
