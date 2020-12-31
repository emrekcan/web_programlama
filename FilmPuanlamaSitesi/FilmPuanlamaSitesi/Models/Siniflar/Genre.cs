using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmPuanlamaSitesi.Models.Siniflar
{
    public class Genre
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string FilmResim { get; set; }
        public string FilmLink { get; set; }
        public string FilmAd { get; set; }
        public string Sure { get; set; }
        public string Kategori { get; set; }
    }
}
