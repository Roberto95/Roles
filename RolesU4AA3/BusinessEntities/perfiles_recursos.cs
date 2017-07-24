using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class perfiles_recursos
    {
        public byte consultar { get; set; }
        public byte agregar { get; set; }
        public byte editar { get; set; }
        public byte eliminar { get; set; }
        public int recursoId { get; set; }
        public int perfilId { get; set; }


    }
}
