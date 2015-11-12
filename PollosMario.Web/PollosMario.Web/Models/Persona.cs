using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PollosMario.Web.Models
{
    public class Persona
    {
        public int Id { get; set; }
        [Required]
        public string Cedula { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public string Telefono { get; set; }
        [Required]
        public string Celular { get; set; }
        [Required]
        public string Direccion { get; set; }
    }
}