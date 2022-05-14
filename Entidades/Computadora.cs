using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Computadora:Elemento
    {
        public string DescripcionProcesador { get; set; }
        public int CantidadMemoriaRam { get; set; }
        public string NombreFabricante { get; set; }

    }
}
