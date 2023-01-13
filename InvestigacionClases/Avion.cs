namespace InvestigacionClases
{
    public abstract class Avion
    {

        public Avion(string piloto, string copiloto, string azafata)
        {

            Piloto = piloto;
            Copiloto = copiloto;
            Azafata = azafata;

        }

        public string Piloto { get; set; }

        public string Copiloto { get; set; }

        public string Azafata { get; set; }

        public string Aterriza(string horario)
        {
            return $"El avión aterriza en Ezeiza a las {horario}";
        }

        public string Despega(string horario)
        {
            return $"El avión despega de Miami a las {horario}";
        }

    }
}