using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiMagos.Models.Response;
using ApiMagos.Models;
using ApiMagos.Models.Request;

namespace ApiMagos.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class InscripcionController : Controller
    {
      [HttpGet]
      public IActionResult Get()
        {
            Respuesta<List<Inscripcion>> oRespuesta = new Respuesta<List<Inscripcion>>();

            try { 

            using (sql10433703Context  db = new sql10433703Context() )
            {
                var lst = db.Inscripcions.ToList();
                oRespuesta.Exito = 1;
                oRespuesta.Data = lst;

            }

            }
            catch (Exception ex) {
                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }



        [HttpGet ("{id}") ]
        public IActionResult Get(int id)
        {
            Respuesta<Inscripcion> oRespuesta = new Respuesta<Inscripcion>();

            try
            {

                using (sql10433703Context db = new sql10433703Context())
                {
                    var lst = db.Inscripcions.Find(id);
                    oRespuesta.Exito = 1;
                    oRespuesta.Data = lst;

                }

            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }


        [HttpPost]
        public IActionResult Add(InscripcionRespuesta model)
        {
            Respuesta<object> oRespuesta = new Respuesta<object>();

            try
            {

                using (sql10433703Context db = new sql10433703Context())
                {
                    Inscripcion oInscripcion = new Inscripcion();
                    oInscripcion.Nombre = model.nombre;
                    oInscripcion.Apellido = model.apellido;
                    oInscripcion.Identificacion = model.identificacion;
                    oInscripcion.Edad = model.edad;
                    oInscripcion.Casa = model.casa;
                    db.Inscripcions.Add(oInscripcion);
                    db.SaveChanges();
                    oRespuesta.Exito = 1;

                }

            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }

        [HttpPut]
        public IActionResult Edit(InscripcionRespuesta model)
        {
            Respuesta<object> oRespuesta = new Respuesta<object>();

            try
            {

                using (sql10433703Context db = new sql10433703Context())
                {
                    Inscripcion oInscripcion = db.Inscripcions.Find(model.id);
                    oInscripcion.Nombre = model.nombre;
                    oInscripcion.Apellido = model.apellido;
                    oInscripcion.Identificacion = model.identificacion;
                    oInscripcion.Edad = model.edad;
                    oInscripcion.Casa = model.casa;
                    db.Entry(oInscripcion).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    oRespuesta.Exito = 1;

                }

            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }



        [HttpDelete("{id}") ]
        public IActionResult Delete(int id)
        {
            Respuesta<object> oRespuesta = new Respuesta<object>();

            try
            {

                using (sql10433703Context db = new sql10433703Context())
                {
                    Inscripcion oInscripcion = db.Inscripcions.Find(id);
                    db.Remove(oInscripcion);
                    db.SaveChanges();
                    oRespuesta.Exito = 1;

                }

            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }
    }
}