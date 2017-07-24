using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TableHtml.Models
{
    public class prestamo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Amount { get; set; }
        public float Percentage { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechadelPrestamo { get; set; }
        
    }
}