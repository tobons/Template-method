using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_method
{
    public class PrestamoPersonal:Prestamo
    {
        public int monto;
        public Cliente titular;
        public int meses;
        public PrestamoPersonal(Cliente titular, int monto, int meses) : base(titular, meses, monto)
        {
            this.titular = titular;
            this.monto = monto;
            this.meses = meses;
        }
        

     

        public override double calcular_cuota()
        {
            double interes = this.monto * 0.04; // El prestamo personal tiene un interes del 4%
            double cuota = this.monto / this.meses + interes; // El valor de la cuota mensual
            return cuota;
        }

       

        public override void calcular_total(double cuota)
        {
            Console.WriteLine("Señ@r " + this.titular.nombre + " en total vas a pagar " + cuota * this.meses + " por tu prestamo");
        }
    }
}
