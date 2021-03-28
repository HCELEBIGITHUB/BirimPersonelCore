using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BirimPersonelCoreMVC.Models
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }
        [MaxLength(20, ErrorMessage = "Adı 20 Karakterden Uzun Olamaz..")]
        public string Ad { get; set; }
        [MaxLength(20, ErrorMessage = "Birim Soyad 20 Karakterden Uzun Olamaz..")]
        public string Soyad { get; set; }
        [MaxLength(20, ErrorMessage = "Sehir 20 Karakterden Uzun Olamaz..")]
        public string Sehir { get; set; }
        public int BirimID { get; set; }
        public Birim Birims { get; set; }

    }
}
