using System;
using System.Collections.Generic;
using System.Text;

namespace Api_covid.Model
{
    class Provincia
    {
        public string nombre;
        public string capital;
        public double superficie;
        public double contagiados;
        public double recuperados;
        public double fallecidos;
        public Provincia(string nombre, string capital, double superficie, double contagiados, double recuperados, double fallecidos)
        {
            this.nombre = nombre;
            this.capital = capital;
            this.superficie = superficie;
            this.contagiados = contagiados;
            this.recuperados = recuperados;
            this.fallecidos = fallecidos;
        }
    }
}
