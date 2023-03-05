using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace _16_MVC_Uygulama2.Models
{
    public class Employee
    {
        [Display(Name = "Calisan Kodu")]
        public int Id { get; set; }

        [Display(Name = "Isim")]
        [Required(ErrorMessage = "Isim bilgisi zorunludur!")]
        public string Name { get; set; }

        [Display(Name = "Soyisim")]
        [Required(ErrorMessage = "Soyisim bilgisi zorunludur!")]
        public string Surname { get; set; }

        [Display(Name = "Dogum Tarihi")]
        [Required(ErrorMessage = "Dogum tarihi bilgisi zorunludur!")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Unvan")]
        public string Title { get; set; }
    }
}
