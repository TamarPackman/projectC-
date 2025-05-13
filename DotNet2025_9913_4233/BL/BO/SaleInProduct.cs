namespace BO
{
    public class SaleInProduct
    {
        public int saleId { get; set; }
        public int quantityForSale { get; set; }
        public double Price { get; set; }
        public bool isSaleForAllCustomers { get; set; }

        // בנאי ברירת מחדל
        public SaleInProduct()
        {
            saleId = 0;
            quantityForSale = 0;
            Price = 0;
            isSaleForAllCustomers = false;
        }
        public SaleInProduct(int saleId, int quantityForSale, double Price, bool isSaleForAllCustomers)
        {
           this. saleId = saleId;
           this. quantityForSale = quantityForSale;
           this. Price = Price;
           this. isSaleForAllCustomers = isSaleForAllCustomers;
        }
        // Override של ToString
        public override string ToString() => Tools.ToStringProperty(this);
    }
}
