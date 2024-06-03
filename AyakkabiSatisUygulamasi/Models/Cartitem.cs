namespace AyakkabiSatisUygulamasi.Models
{
    public class Cartitem
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public Decimal Price { get; set; }
        public string Image { get; set; }
        public Decimal Total
        {
            get { return Quantity * Price; }
        }
        public Cartitem() { }
        public Cartitem(Products products)
        {
            ProductId = products.ProductId;
            ProductName = products.ProductName;
            Quantity = 1;
            Price=Convert.ToDecimal (products.ProductPrice);
            Image = products.ProductPicture;
        }
    }
}
