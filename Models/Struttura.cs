using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SanitaOggi.Models
{
    public class Struttura
    {
        [Key]
        public string StrutturaID { get; set; } //identificativo obbligatorio

        [Required]
        [Display(Name = "Codice struttura")]
        public string CodiceStruttura { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string NomeStruttura { get; set; }
    }
}
