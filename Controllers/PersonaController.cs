using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;
using Newtonsoft.Json;

namespace WebAPI.Controllers
{
    public class PersonaController : ApiController
    {
        [HttpGet]
        [Route("api/Persona/obtener/{id}")]
        public HttpResponseMessage ObtenerPersonas(int id) {
            List<Persona> lista = new List<Persona>();
            lista.Add(new Persona(1, "115510467", "Jason Bonilla"));
            lista.Add(new Persona(2, "123456789", "Bryan"));

            return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(lista));
        }

        [HttpPost]
        [Route("api/Persona/datos")]
        public HttpResponseMessage PostPersona(Persona persona)
        {
            return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(new Persona(1, "115510467", "Jason Bonilla")));
        }


    }
}
