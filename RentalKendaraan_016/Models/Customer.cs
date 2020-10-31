using System;
using System.Collections.Generic;

namespace RentalKendaraan_016.Models
{
    public partial class Customer
    {
        public int ID_Customer { get; set; }
        public string Nama_Customer { get; set; }
        public string NIK { get; set; }
        public string Alamat { get; set; }
        public string No_Hp { get; set; }
        public int? ID_Gender { get; set; }
    }
}
