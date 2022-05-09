using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_CORE_IlkProje.Models
{
    public class Kullanici
    {
        [StringLength(10, ErrorMessage = "Ürün adı en fazla 10 karakter olmalıdır.")]
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
