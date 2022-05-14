using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class ModificacionEventArgs:EventArgs
    {
        public string TipoProducto { get; set; }
        public int Id { get; set; }
        public string Accion { get; set; }
    }
}
