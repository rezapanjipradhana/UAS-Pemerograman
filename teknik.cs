using System;
using System.Collections.Generic;
using System.Text;

namespace PendaftaranMahasiswa
{
    public class teknik : Data
    {
        public double spp { get; set; }
        public double gedung { get; set; }
        public double praktik { get; set; }

    public override double biaya()
        {
            double jumlah = spp + gedung + praktik;
            return jumlah;
        }
    }
}
