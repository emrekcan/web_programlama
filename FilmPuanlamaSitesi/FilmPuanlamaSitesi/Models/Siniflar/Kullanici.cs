using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmPuanlamaSitesi.Models.Siniflar
{
    public class Kullanici
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Kullanıcı adını boş bırakmazsın!!!")]
        public string KullaniciAd { get; set; }

        [Required(ErrorMessage = "Şifreyi boş bırakamazsın!!!")]
        public string Sifre { get; set; }

        [Required(ErrorMessage = "Emaili boş bırakamazsın!!!")]
        public string Email { get; set; }
    }
}
