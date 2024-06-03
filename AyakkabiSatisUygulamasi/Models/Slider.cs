using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AyakkabiSatisUygulamasi.Models
{
    public class Slider
        //slider ekranımızdaki ürünleri gösteren alan
        /* burada birden çoklu ilişki kullandım çünkü bir tablo içerisinde bir tane kategoriye ait olabilir
         * ama bir kategori içerisinde birden fazla ürün değeri taşıyabilir
         */
    {
        [Key]
        public int SliderId { get; set; }
        public string? SliderName { get; set; } = string.Empty;

        // slider başlığı 1
        public string? Header1 { get; set; } = string.Empty;
        //slider başlığı 2
        public string? Header2 { get; set; } = string.Empty;

        //içerik
        public string? Context { get; set; } = string.Empty;
        public string? SliderImage { get; set; } = string.Empty;
        [NotMapped]
        public IFormFile? ImageUpload { get; set; }
    }
}
