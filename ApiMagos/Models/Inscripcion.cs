using System;
using System.Collections.Generic;

#nullable disable

namespace ApiMagos.Models
{
    public partial class Inscripcion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Identificacion { get; set; }
        public int Edad { get; set; }
        public string Casa { get; set; }
    }
}
