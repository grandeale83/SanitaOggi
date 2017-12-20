using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SanitaOggi.Models
{
    public class Ambulatorio
    {
        [Key]
        public string AmbulatorioID { get; set; }

        [Required]
        [Display(Name = "Tipo")]
        public string CodTipo { get; set; }

        [Required]
        [Display(Name = "Struttura")]
        public string CodStruttura { get; set; }
    }
}
