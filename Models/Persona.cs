using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Persona
    {
        public int ID { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }

        public Persona() { }

        public Persona(int id, string cedula, string nombre) {
            this.ID = id;
            this.Cedula = cedula;
            this.Nombre = nombre;
        }
    }
}