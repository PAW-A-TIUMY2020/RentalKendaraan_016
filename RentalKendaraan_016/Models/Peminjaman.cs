using System;
using System.Collections.Generic;

namespace RentalKendaraan_016.Models
{
    public partial class Peminjaman
    {
        public int ID_Peminjaman { get; set; }
        public DateTime? Tgl_Peminjaman { get; set; }
        public int? ID_Kendaraan { get; set; }
        public int? ID_Costumer { get; set; }
        public int? ID_Jaminan { get; set; }
        public int? Biaya { get; set; }
    }
}
