using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SanitaOggi.Models
{
    public class Esame
    {
        [Key]
        public int EsameID { get; set; }

        [Required]
        [Display(Name = "Codice")]
        public string CodiceEsame { get; set; }

        [Required]
        [Display(Name = "Nome Esame")]
        public string NomeEsame { get; set; }

        [Required]
        [Display(Name = "Tipo")]
        public string NomeTipo { get; set; }
    }
}
