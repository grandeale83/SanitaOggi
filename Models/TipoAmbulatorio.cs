using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SanitaOggi.Models
{
    public class TipoAmbulatorio
    {
        [Key]
        public string TipoAmbulatorioID { get; set; } //identificativo obbligatorio?

        [Required]
        [Display(Name = "Codice tipologia")]
        public string CodiceTipo { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string NomeTipo { get; set; }
    }
}
