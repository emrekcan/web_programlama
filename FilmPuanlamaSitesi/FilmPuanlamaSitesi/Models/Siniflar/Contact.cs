using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmPuanlamaSitesi.Models.Siniflar
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Konu { get; set; }
        public string Mail { get; set; }
        public string TelefonNumarasi { get; set; }
        public string Mesaj { get; set; }

    }
}
