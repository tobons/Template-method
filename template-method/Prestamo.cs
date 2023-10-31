using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_method
{
    public abstract class Prestamo
    {
        Cliente titular;
        int meses;
        int monto;
        public Prestamo(Cliente titular, int meses, int monto)
        {
            this.titular = titular;
            this.meses = meses;
            this.monto = monto;

        }
        public abstract double calcular_cuota();
        public abstract void calcular_total(double cuota);
        public virtual bool validar_propiedad() {return true;}

        public void realizar_prestamo()
        {
            if (!this.validar_edad()) { return; }
            if (!this.validar_historial()) { return; }
            if (!this.validar_ingresos()) { return; }
            if (!this.validar_propiedad()) { return; }
            if (!this.validar_edad()) { return; }
            double cuota = this.calcular_cuota();
            if (!this.validar_capacidad(cuota)) { return; }
            this.calcular_total(cuota);

        }
        public bool validar_edad()
        {
            if (this.titular.edad >= 18)
            {
                return true;
            }
            else
            {
                Console.WriteLine("El prestamo no ha sido aceptado porque eres menor de edad");
                return false;
            }
        }
        public bool validar_historial()
        {
            if (this.titular.historialCrediticio >= 6) //Asumiento que el historial crediticio sea un puntaje de 1 a 10
            {
                return true;
            }
            else
            {
                Console.WriteLine("El prestamo no ha sido aceptado ya que no tiene el puntaje requerido en el historial crediticio");
                return false;
            }
        }
        public bool validar_ingresos()
        {
            if (this.titular.ingresosDemostrados)
            {
                return true;
            }
            else
            {
                Console.WriteLine("El prestamo no ha sido posible ya que no tienes la demostración de tus ingresos");
                return false;
            }
        }

        public bool validar_capacidad(double cuota)
        {
            if (this.titular.capacidad > cuota)
            {
                return true;
            }
            else
            {
                Console.WriteLine("El prestamo no sido posible ya que no tiene la capacidad necesaria para prestar el coche");
                return false;
            }
        }
    }
}
