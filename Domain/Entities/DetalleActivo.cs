using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DetalleActivo
    {
        public int id { get; set; }
        public Activo activo { get; set; }
        public Empleado empleado { get; set; }
        public DateTime Fecha { get; set; }
        public byte Estado { get; set; }
    }
}
