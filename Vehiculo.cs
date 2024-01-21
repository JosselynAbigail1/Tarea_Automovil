using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Automovil
{ 
   abstract class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }

        public Vehiculo(string marca, string modelo, int anio)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
        }

        protected Vehiculo()
        {
        }

        public virtual string GetInformation()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Año: {Anio}";
        }

        public abstract void RunAction();

        public override bool Equals(object? obj)
        {
            return obj is Vehiculo vehiculo &&
                   Marca == vehiculo.Marca &&
                   Modelo == vehiculo.Modelo &&
                   Anio == vehiculo.Anio;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Marca, Modelo, Anio);
        }
    }
}
