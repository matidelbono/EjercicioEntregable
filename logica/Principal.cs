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
        public EventHandler<ModificacionEventArgs> ModificacionRealizada;
        public void AgregarElemento(string DescripcionProcesador, int CantidadMemoriaRam, string NombreFabricante)
        {
            Computadora nuevacomputadora=new Computadora();
            nuevacomputadora.DescripcionProcesador = DescripcionProcesador;
            nuevacomputadora.CantidadMemoriaRam = CantidadMemoriaRam;
            nuevacomputadora.NombreFabricante=NombreFabricante;
            computadoras.Add(nuevacomputadora);
            if (this.ModificacionRealizada != null)
                this.ModificacionRealizada(this, new ModificacionEventArgs());
            
        }
        public void AgregarElemento(int anioFabricacion, int Pulgadas)
        {
          Pantalla nuevaPantalla=new Pantalla();
            nuevaPantalla.AnioFabricacion=anioFabricacion;
            nuevaPantalla.Pulgadas=Pulgadas;
            pantallas.Add(nuevaPantalla);
            if (this.ModificacionRealizada != null)
                this.ModificacionRealizada(this, new ModificacionEventArgs());




        }
    }
}