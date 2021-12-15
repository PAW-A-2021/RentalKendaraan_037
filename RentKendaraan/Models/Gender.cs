using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RentKendaraan.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Customers = new HashSet<Customer>();
        }

        public int IdGender { get; set; }
        [MinLength(1, ErrorMessage = "Nama Gender minimal 1 huruf")]
        [MaxLength(1, ErrorMessage = "Nama Gender maksimal 1 huruf")]
        public string NamaGender { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
