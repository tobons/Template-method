using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_method
{
    public class Cliente
    {
        public string nombre;
        public int edad;
        public int historialCrediticio;
        public int capacidad;
        public bool ingresosDemostrados;
        public int propiedades;
        public Cliente(string nombre, int edad, int historialCrediticio, int capacidad, int propiedades, bool ingresosDemostrados = false)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.historialCrediticio = historialCrediticio;
            this.capacidad = capacidad;
            this.propiedades = propiedades;
            this.ingresosDemostrados = ingresosDemostrados;
        }
    }
}
