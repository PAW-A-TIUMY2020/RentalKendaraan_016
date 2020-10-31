using System;
using System.Collections.Generic;

namespace RentalKendaraan_016.Models
{
    public partial class Kendaraan
    {
        public int ID_Kendaraan { get; set; }
        public string Nama_Kendaraan { get; set; }
        public string No_Polisi { get; set; }
        public string No_STNK { get; set; }
        public int? ID_Jenis_Kendaraan { get; set; }
        public string Ketersediaan { get; set; }
    }
}
