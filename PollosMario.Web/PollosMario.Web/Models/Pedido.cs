using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PollosMario.Web.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }      
        public string Direccion { get; set; }
        public string Telefono { get; set; }  
        public virtual Persona Persona { get; set; }
        [ForeignKey("Persona")]
        public int PersonaId { get; set; }
    }
}