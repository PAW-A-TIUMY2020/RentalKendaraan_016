using System;
using System.Collections.Generic;

namespace RentalKendaraan_016.Models
{
    public partial class Pengembalian
    {
        public int ID_Pengembalian { get; set; }
        public DateTime? Tgl_Pengembalian { get; set; }
        public int? ID_Peminjaman { get; set; }
        public int? ID_Kondisi { get; set; }
        public int? Denda { get; set; }
    }
}
