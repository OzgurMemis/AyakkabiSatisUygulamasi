using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AyakkabiSatisUygulamasi.Models
{
    public class Products
    { //Ürün sınıfını Oluşturdum public kullanma sebebim Herhangi bir kod bloğundan erişilebilir olması

        [Key]
        //ürün id
        public int ProductId { get; set; }
        //ürün adı                               string empty boş bir dize 
        [Display(Name = "Ürün Adı")]
        public string? ProductName { get; set; } = string.Empty;
        //ürün kodu
        [Display(Name = "Ürün Kodu")]
        public int? ProductCode { get; set; }
        //ürün açıklaması
        [Display(Name = "Ürün Açıklaması")]
        public string? ProductDescription { get; set; } = string.Empty;
        //ürün fotoğrafı
        [Display(Name = "Ürün Resmi")]
        public string? ProductPicture { get; set; } = string.Empty;
        //ürün fiyatı
        [Display(Name = "Ürün Fiyatı")]
        public int? ProductPrice { get; set; }
        //kategori id
        [Display(Name = "Ürün Kategorisi")]
        public int? CategoryId { get; set; }

        //virtual sanal iletişim oluşturdum kategori sınıfındakileri buraya çektim
        virtual public Category? Category { get; set; }
        [NotMapped]
        //notmapped veri tabanında burayı göstermiyecek
        public IFormFile? ImageUpload { get; set; }
    }
}
