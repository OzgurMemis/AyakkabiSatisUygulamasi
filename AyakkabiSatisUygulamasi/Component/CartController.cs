using AyakkabiSatisUygulamasi.Data;
using AyakkabiSatisUygulamasi.Dto;
using AyakkabiSatisUygulamasi.Models;
using AyakkabiSatisUygulamasi.Oturum;
using Microsoft.AspNetCore.Mvc;

namespace AyakkabiSatisUygulamasi.Component
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CartController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Cartitem> items = HttpContext.Session.GetJson<List<Cartitem>>("Cart")?? new List<Cartitem>();
            CartViewModel cartvm = new()
            {
                cartitems = items,
                GrandTotal = items.Sum(x => x.Quantity * x.Price)
            };
            return View(cartvm);
        }
        public async Task<IActionResult> Add(int id) 
        {
            Products product=_context.Products.Find(id);
            List<Cartitem> items = HttpContext.Session.GetJson<List<Cartitem>>("Cart") ?? new List<Cartitem>();
            Cartitem cartitem=items.FirstOrDefault(x=>x.ProductId==id);
            if (cartitem==null)
            {
                items.Add(new Cartitem(product));
            }
            else
            {
                cartitem.Quantity += 1;
            }
            HttpContext.Session.SetJson("Cart", items);
            TempData["Mesaj"] = "Ürün Sepete Eklenmiştir";
            return Redirect(Request.Headers["Referer"].ToString());
        }
        public async Task<IActionResult> Decrease(int id)
        {
            List<Cartitem> cart = HttpContext.Session.GetJson<List<Cartitem>>("Cart");
            Cartitem cartitem=cart.Where(c=>c.ProductId==id).FirstOrDefault();
            if (cartitem.Quantity>1)
            {
                cartitem.Quantity -= 1;
            }
            else
            {
                cart.RemoveAll(c=>c.ProductId==id);
            }
            if (cart.Count>0)
            {
                HttpContext.Session.SetJson("Cart",cart);
            }
            TempData["Mesaj"] = "Ürün Sepetten Silindi";
            return RedirectToAction("Index");
        }
        public async Task<IActionResult>Remove(int id)
        {

            List<Cartitem> cart = HttpContext.Session.GetJson<List<Cartitem>>("Cart");
            cart.RemoveAll(c=> c.ProductId==id);
            if (cart.Count>0)
            {
                HttpContext.Session.Remove("Cart");
            }
            else
            {
                HttpContext.Session.SetJson("Cart", cart);
            }
            TempData["Mesaj"] = "Ürün Sepeti Silindi";
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Clear()
        {
            HttpContext.Session.Remove("Cart");
            return RedirectToAction("Index");
        }
    }
}
