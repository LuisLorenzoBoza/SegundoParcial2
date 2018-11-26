using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SegundoParcial.Entidades
{
    public class Meta
    {
        [Key]
        public int MetaId { get; set; }
        public string Descripcion { get; set; }
        public float Cuotas { get; set; }

        public virtual List<Meta> Metas { get; set; }
                     
        public Meta(int MetaId, string Descripcion, float Cuotas)
        {
            this.MetaId = MetaId;
            this.Descripcion = Descripcion;
            this.Cuotas = Cuotas;
        }

        public Meta()
        {
            MetaId = 0;
            Descripcion = string.Empty;
            Cuotas = 0;

        }
    }
}
