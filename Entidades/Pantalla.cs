using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class Pantalla:Elemento
    {
        public int AnioFabricacion { get; set; }
        public Nullable<int> Pulgadas { get; set; }
        public bool EsNueva ()
        {
            if (AnioFabricacion == DateTime.Today.Year)
                return true;
            else
                return false;
        }
}
}
