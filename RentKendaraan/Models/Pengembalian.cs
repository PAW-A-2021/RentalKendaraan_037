using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RentKendaraan.Models
{
    public partial class Pengembalian
    {
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public int IdPengembalian { get; set; }
        public DateTime? TglPengembalian { get; set; }
        public int? IdPeminjaman { get; set; }
        public int? IdKondisi { get; set; }
        public int? Denda { get; set; }

        public virtual KondisiKendaraan IdKondisiNavigation { get; set; }
        public virtual Peminjaman IdPeminjamanNavigation { get; set; }
    }
}
