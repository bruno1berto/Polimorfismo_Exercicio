using System.Text;
using System.Globalization;

namespace Polimorfismo_Exercicio.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; protected set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
        public override string PriceTag()
        {
            string tag = Name + " $ " + TotalPrice().ToString("F2") + " (Customs Fee: $ " + CustomsFee.ToString("F2") + ")";
            return tag;
        }
    }
}
