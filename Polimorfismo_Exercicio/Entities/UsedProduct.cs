using System;
using System.Globalization;
using System.Text;

namespace Polimorfismo_Exercicio.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; protected set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            string tag = Name + "(used) $ " + Price.ToString("F2") + " (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
            return tag;
        }
    }
}
