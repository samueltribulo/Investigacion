using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigacionClases
{
    public class AvionCarga:Avion
    {
        public AvionCarga(string piloto, string copiloto, string azafata, double peso, string tipoMercaderia) : base(piloto, copiloto, azafata)
        {
            Peso = peso;
            TipoMercaderia = tipoMercaderia;
        }

        public double Peso { get; set; }

        public string TipoMercaderia { get; set; }


    }
}
