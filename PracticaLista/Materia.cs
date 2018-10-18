using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLista
{
    class Materia
    {
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public int CalificacionPrimerParcial { get; set; }
        public int CalificacionSegundoParcial { get; set; }
        public int CalificacionTercerParcial { get; set; }
        public int CalificacionFinal { get; set; }

        public Materia(string clave, string nombre)
        {
            Clave = clave;
            Nombre = nombre;
            CalificacionPrimerParcial = 0;
            CalificacionSegundoParcial = 0;
            CalificacionTercerParcial = 0;
            CalificacionFinal = 0;
        }
        public Materia(string clave, string nombre, int calificacionPrimerParcial, int calificacionSegundoParcial, 
            int calificacionTercerParcial, int calificacionFinal)
        {
            Clave = clave;
            Nombre = nombre;
            CalificacionPrimerParcial = calificacionPrimerParcial;
            CalificacionSegundoParcial = calificacionSegundoParcial;
            CalificacionTercerParcial = calificacionTercerParcial;
            CalificacionFinal = calificacionFinal;
        }
    }
}
