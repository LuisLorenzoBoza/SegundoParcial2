using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SegundoParcial.Entidades
{
    public class Vendedor
    {
        [Key]
        public int IDVendedor { get; set; }
        public string Nombre { get; set; }
        public float Sueldo { get; set; }
        public float Retecion { get; set; }
        public float Total { get; set; }
        public DateTime Fecha { get; set; }
        public float Retencion { get; internal set; }
        public float meta { get; set; }
        public virtual List<Meta> Metas { get; set; }

        public Vendedor()
        {
            IDVendedor = 0;
            Nombre = string.Empty;
            Sueldo = 0;
            Retecion = 0;
            Total = 0;
            Fecha = DateTime.Now;
            meta = 0;
            Metas = new List<Meta>();
        }

    }
}
