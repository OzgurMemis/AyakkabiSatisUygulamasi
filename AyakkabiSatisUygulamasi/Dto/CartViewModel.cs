using AyakkabiSatisUygulamasi.Models;

namespace AyakkabiSatisUygulamasi.Dto
{
    public class CartViewModel
    {
        public List<Cartitem> cartitems { get; set; }
        public decimal GrandTotal { get; set; }
    }
}
