using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigacionClases
{
    public class AvionComercial:Avion
    {
        public AvionComercial(string piloto, string copiloto, string azafata, double capacidad, string lineaAerea):base(piloto, copiloto, azafata)
        {
            Capacidad = capacidad;
            LineaAerea= lineaAerea;
        }  

        public double Capacidad { get; set; }

        public string LineaAerea { get; set; }

        public override string ToString()
        {
            return 
                $"Avion\n" +
                $"Piloto: {this.Piloto}\n" +
                $"Copiloto: {this.Copiloto}\n" +
                $"Azafata: {this.Azafata}\n" +
                $"Capacidad {this.Capacidad}\n" +
                $"LineaAerea {this.LineaAerea}"
                ;
        }

    }
}
