using System;

namespace Api_covid.models
{
    public class Provincia
    {
        public int idprovincia { get; set; }
        public string provincia { get; set; }
        public string capital { get; set; }
        public double superficie { get; set; }
        public double hombres { get; set; }
        public double mujeres { get; set; }
        public double problacion_total { get; set; }
        public double contagiados { get; set; }
        public double recuperados { get; set; }
        public double fallecidos { get; set; }
    }
}
