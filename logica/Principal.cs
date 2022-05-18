using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace logica
{
    
    public sealed class Principal
    {
        public List<Pantalla> pantallas = new List<Pantalla>();
        public List<Computadora> computadoras = new List<Computadora>();
        public static Principal Instance = null;
        private Principal()
        {

        }
        public static Principal instance
        {
            get
            {
                if (Instance == null)
                    Instance = new Principal();
                return Instance;
            }
        }
       
        public void AgregarElemento(string marca, string modelo, int NumerodeSerie,string DescripcionProcesador, int CantidadMemoriaRam, string NombreFabricante, int Id)
        {
            computadoras.Add(new Computadora(marca, modelo, NumerodeSerie, Id,DescripcionProcesador,CantidadMemoriaRam,NombreFabricante))
          
        }
        public void AgregarElemento(string marca, string modelo, int NumerodeSerie,int anioFabricacion, int Pulgadas)
        {
            pantallas.Add(new Pantalla(marca, modelo, NumerodeSerie, anioFabricacion, Pulgadas));
        }
    }
}