using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Automovil
{
    internal class Camioneta:Vehiculo
    {
      public double CapacidadCarga { get; set; }

        public Camioneta(string marca, string modelo, int anio, double capacidadCarga)
            : base(marca, modelo, anio)
        {
            CapacidadCarga = capacidadCarga;
        }

        public override string GetInformation()
        {
            return $"{base.GetInformation()}, Capacidad de Carga: {CapacidadCarga} kg";
        }

        public override void RunAction()
        {
            Console.WriteLine("Cargando camioneta...");
        }
    }

}

