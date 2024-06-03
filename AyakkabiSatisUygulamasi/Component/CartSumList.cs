using AyakkabiSatisUygulamasi.Data;
using AyakkabiSatisUygulamasi.Dto;
using AyakkabiSatisUygulamasi.Models;
using AyakkabiSatisUygulamasi.Oturum;
using Microsoft.AspNetCore.Mvc;

namespace AyakkabiSatisUygulamasi.Component
{
    public class CartSumList:ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public CartSumList(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            List<Cartitem> cart = HttpContext.Session.GetJson<List<Cartitem>>("Cart") ?? new List<Cartitem>();
            CartViewModel cartvm = new()
            {
                cartitems = cart,
                GrandTotal = cart.Sum(x => x.Quantity * x.Price)
            };
            return View(cartvm);
        }
        
    }
}
