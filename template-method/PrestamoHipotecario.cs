using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_method
{
    public class PrestamoHipotecario
    {
        public Cliente titular;
        public int monto;
        public int meses;
        public PrestamoHipotecario(Cliente titular, int monto, int meses)
        {
            this.titular = titular;
            this.monto = monto;
            this.meses = meses;
            this.validar_edad();
        }
        public void validar_edad()
        {
            if (this.titular.edad >= 18)
            {
                this.validar_historial();
            }
            else
            {
                Console.WriteLine("El prestamo no ha sido aceptado porque eres menor de edad");
            }
        }

        public void validar_historial()
        {
            if (this.titular.historialCrediticio >= 6) //Asumiento que el historial crediticio sea un puntaje de 1 a 10
            {
                this.validar_ingresos();
            }
            else
            {
                Console.WriteLine("El prestamo no ha sido aceptado ya que no tiene el puntaje requerido en el historial crediticio");
            }
        }

        public void validar_ingresos()
        {
            if (this.titular.ingresosDemostrados)
            {
                this.validar_propiedad();
            }
            else
            {
                Console.WriteLine("El prestamo no ha sido posible ya que no tienes la demostración de tus ingresos");
            }
        }

        public void validar_propiedad()
        {
            if (this.titular.propiedades > 0)
            {
                this.calcular_cuota();
            }
            else
            {
                Console.WriteLine("El prestamo no ha sido posible ya que no tienes propiedades a tu nombre");
            }
        }

        public void calcular_cuota()
        {
            double interes = this.monto * 0.06; // El prestamo hipotecario tiene un interes del 6%
            double cuota = this.monto / this.meses + interes; // El valor de la cuota mensual
            validar_capacidad(cuota);
        }

        public void validar_capacidad(double cuota)
        {
            if (this.titular.capacidad > cuota)
            {
                this.calcular_total(cuota);
            }
            else
            {
                Console.WriteLine("El prestamo no sido posible ya que no tiene la capacidad necesaria para prestar el coche");
            }
        }

        public void calcular_total(double cuota)
        {
            Console.WriteLine("Señ@r " + this.titular.nombre + " en total vas a pagar " + cuota * this.meses + " por tu prestamo hipotecario");
        }
    }
}
