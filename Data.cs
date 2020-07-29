using System;
using System.Collections.Generic;
using System.Text;

namespace PendaftaranMahasiswa
{
    public abstract class Data
    {
        public string no { get; set; }
        public string nama { get; set; }

        public abstract double biaya();
    }
}
