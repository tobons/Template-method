using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_method
{
    public class PrestamoHipotecario:Prestamo
    {
        public Cliente titular;
        public int monto;
        public int meses;
        public PrestamoHipotecario(Cliente titular, int monto, int meses) : base(titular, meses, monto)
        {
            this.titular = titular;
            this.monto = monto;
            this.meses = meses;
        }
       
        public override bool validar_propiedad()
        {
            if (this.titular.propiedades > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("El prestamo no ha sido posible ya que no tienes propiedades a tu nombre");
                return false;
            }
        }

        public override double calcular_cuota()
        {
            double interes = this.monto * 0.06; // El prestamo hipotecario tiene un interes del 6%
            double cuota = this.monto / this.meses + interes; // El valor de la cuota mensual
            return cuota;
        }

        

        public override void calcular_total(double cuota)
        {
            Console.WriteLine("Señ@r " + this.titular.nombre + " en total vas a pagar " + cuota * this.meses + " por tu prestamo hipotecario");
        }
    }
}
