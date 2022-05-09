using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_CORE_IlkProje.Models
{
    public class Urun
    {
        [StringLength(50,ErrorMessage ="Ürün adı en fazla 50 karakter olmalıdır.")]
        public string _adi { get; set; }
        public decimal _fiyat { get; set; }
    }
}
