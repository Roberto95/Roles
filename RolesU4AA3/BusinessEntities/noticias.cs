using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class noticias
    {
        public int Id { get; set; }
        public int usuarioId { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha_registro { get; set; }
        public DateTime fecha_modificacion { get; set; }
        public byte estado { get; set; }

    }
}
