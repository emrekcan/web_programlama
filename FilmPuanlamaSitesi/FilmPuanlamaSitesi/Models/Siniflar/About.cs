using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmPuanlamaSitesi.Models.Siniflar
{
    public class About
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string FotoUrl { get; set; }
        public string Aciklama { get; set; }
        public int Istatistik { get; set; }
    }
}
