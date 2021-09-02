Información sistema de inscripciones


Sistema desarrollado en SQL server, .net 5.0, & Blazor
Lenguaje C#


Endpoints


GET:


/api/Inscripcion : Obtener todos los registros de la base de datos


/api/Inscripcion/:id : Recibe como parámetro el id del registro que se quiere obtener, se utiliza principalmente para obtener el registro que se va a editar 


POST:


/api/Inscripcion : Recibe un objeto JSON con los datos del aspirante y los almacena en la base de datos 
{
   "nombre":"string",
   "apellido": "string",
   "identificacion":number,
   "edad":number,
   "casa":"string"}




PUT:
 
/api/Inscripcion : Después de recibir el objeto a modificar con el método get  que recibe como parámetro el id envía el un objeto con los datos y actualiza el registro en la base de datos








DELETE:
 
/api/Inscripcion/:id : Recibe el parámetro del id de un registro y lo elimina de la base de datos


El api también está soportado con swagger para hacer respectivas pruebas /swagger




Como ejecutar


Abra la solucion “ApiMagos”, Ejecute la capa  “ApiMagos”, luego Ejecute la capa “RegistroDeMagos”