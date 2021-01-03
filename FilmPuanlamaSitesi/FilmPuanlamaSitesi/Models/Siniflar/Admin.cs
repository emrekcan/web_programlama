using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmPuanlamaSitesi.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adını boş bırakma!!!")]
        public string KullaniciAd { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi boş bırakma!!!")]
        public string Sifre { get; set; }

        [Required(ErrorMessage = "Lütfen emaili boş bırakma!!!")]
        public string Email { get; set; }

    }
}
