using AyakkabiSatisUygulamasi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace AyakkabiSatisUygulamasi.Component
{
    public class BegenilenList:ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public BegenilenList(ApplicationDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var result=_context.Products.ToList();
            return View(result);
        }
    }
}
