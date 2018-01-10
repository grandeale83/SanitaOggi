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
        [Display(Name = "Nome Ambulatorio")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Tipo Ambulatorio")]
        public string NomeTipo { get; set; }

        [Required]
        [Display(Name = "Struttura")]
        public string NomeStruttura { get; set; }
    }
}
