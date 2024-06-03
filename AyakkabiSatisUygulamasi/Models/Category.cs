using System.ComponentModel.DataAnnotations;

namespace AyakkabiSatisUygulamasi.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Display(Name = "Kategori Adı")]
        [Required(ErrorMessage = "Bu Alan Boş Bırakılamaz")]
        public string? CategoryName { get; set; }

        //birden fazla ürün buraya gelebilir diye belirttik
        virtual public List<Products>? Products { get; set; }
    }
}
