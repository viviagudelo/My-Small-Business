using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySmallBusiness.Models
{
    public class Emprendimiento
    {
        public long ID { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int Categoria {get; set;}
    }
}