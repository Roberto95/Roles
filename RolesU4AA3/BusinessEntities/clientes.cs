using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class clientes
    {
        public int Id { get; set; }
        public int usuarioId { get; set; }
        public string nombre { get; set; }
        public string fecha_nacimiento { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string fecha_registro { get; set; }
    }
}
