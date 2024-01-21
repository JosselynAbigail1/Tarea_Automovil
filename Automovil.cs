using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Automovil
{
    class Automovil:Vehiculo
    {
        public int Puertas { get; set; }

        public Automovil(string marca, string modelo, int anio, int puertas)
            : base(marca, modelo, anio)
        {
            Puertas = puertas;
        }

        public override string GetInformation()
        {
            return $"{base.GetInformation()}, Puertas: {Puertas}";
        }

        public override void RunAction()
        {
            Console.WriteLine("Conduciendo automóvil...");
        }
    }
}

