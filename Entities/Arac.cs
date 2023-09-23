using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Arac
    {
        [Key]
        public string Plaka { get; set; }
        public string Renk { get; set; }

        public int ModelYili { get; set; }

        public string ModelAdi { get; set; }

        public bool? OtomatikPilot { get; set; }

        public decimal? Fiyat { get; set; }

        public bool? Temiz { get; set; }

        public decimal? BagajHacmi { get; set; }
        public bool? YedekLastik { get; set; }
        public override string ToString()
        {
            return $"{Plaka} {ModelAdi}";
        }
    }
}
