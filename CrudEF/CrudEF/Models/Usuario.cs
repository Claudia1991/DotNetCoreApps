using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEF.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El telèfono es obligatorio.")]
        [Display(Name ="Telèfono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El celular es obligatorio.")]
        public string Celular { get; set; }
    }
}
