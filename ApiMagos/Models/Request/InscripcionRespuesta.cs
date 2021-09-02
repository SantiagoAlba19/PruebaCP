using System;
namespace ApiMagos.Models.Request
{
    public class InscripcionRespuesta
    {

        public int id {get; set;}
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int identificacion { get; set; }
        public int edad { get; set; }
        public string casa { get; set; }

     
    }
}
