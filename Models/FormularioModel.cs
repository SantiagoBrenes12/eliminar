using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoWEB.Models
{
    public class FormularioModel
    {
    
        [Key]
        public int Cedula { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Correo es obligatorio")]
        public string Correo { get; set; }
        [StringLength(9, MinimumLength = 9)]
        [Required(ErrorMessage = "El campo Celular es obligatorio")]
        public int Celular { get; set; }

        [Required(ErrorMessage = "El campo Especialidad es obligatorio")]
        public string Especialidad { get; set; }
    }
}
