using System.Text;
using System.Globalization;


namespace Course.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; set; }
        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customFee):base(name, price)
        {
            CustomFee = customFee;
        }
        public double TotalPrice()
        {
            return CustomFee + Price;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append (Name + " S " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Customs fee: $ " + CustomFee.ToString("F2",CultureInfo.InvariantCulture) + ")");
            return sb.ToString();
        }
    }
}
