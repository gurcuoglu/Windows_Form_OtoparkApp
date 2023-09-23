using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public sealed class Sinif1Arac : Arac
    {
        public bool OtomatikPilot { get; set; }
        public decimal Fiyat { get; set; }

        public bool Temiz { get; set; }// default zaten false
    }
}
