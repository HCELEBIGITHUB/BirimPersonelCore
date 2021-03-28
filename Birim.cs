using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BirimPersonelCoreMVC.Models
{
    public class Birim
    {
        [Key]
        public int BirimID { get; set; }
        [MaxLength(20, ErrorMessage = "Birim Adı 20 Karakterden Uzun Olamaz..")]
        public string BirimAd { get; set; }
        public IList<Personel> Personels { get; set; }

    }
}
