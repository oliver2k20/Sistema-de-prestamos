using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TableHtml.Models
{
    public class cliente
    {
         [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechadeNacimiento { get; set; }
        public string EstadoCivil { get; set; }



    }
}