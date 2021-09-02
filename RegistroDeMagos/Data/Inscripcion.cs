using System;
using System.ComponentModel.DataAnnotations;

namespace RegistroDeMagos.Data
{
    public class Inscripcion
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(20, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres ", MinimumLength = 3)]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Solo se admiten letras en este campo")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(20, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres ", MinimumLength = 3)]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Solo se admiten letras en este campo")]
        public string Apellido { get; set; }

        [Range(0, 9999999999, ErrorMessage = "Please enter valid integer Number")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número es obligatorio")]
        public int Identificacion { get; set; }
        [Range(0, 99, ErrorMessage = "Please enter valid integer Number")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número es obligatorio")]
        public int Edad { get; set; }
        [Required(ErrorMessage = "La casa es obligatoria")]
        public string Casa { get; set; }
    }
}

