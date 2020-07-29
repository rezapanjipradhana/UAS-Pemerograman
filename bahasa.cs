using System;
using System.Collections.Generic;
using System.Text;

namespace PendaftaranMahasiswa
{
    public class bahasa : Data
    {
        public double spp { get; set; }
        public double gedung { get; set; }

        public override double biaya()
        {
            double jumlah = spp + gedung;
            return jumlah;
        }
    }
}
