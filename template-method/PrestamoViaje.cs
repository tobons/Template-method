using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_method
{
    public class PrestamoViaje:Prestamo
    {
        public Cliente titular;
        public int monto;
        public int meses;
        public string destino;


        public PrestamoViaje(Cliente titular, int monto, int meses, string destino) :base(titular,meses,monto)
        {
            this.titular = titular;
            this.monto = monto;
            this.meses = meses;
            this.destino = destino;
        }

        

        

        public override double calcular_cuota()
        {
            double interes = this.monto * 0.25; // El prestamo el coche tiene un interes del 2.5%
            double cuota = this.monto / this.meses + interes; // El valor de la cuota mensual
            return cuota;
        }

        

        public override void calcular_total(double cuota)
        {
            Console.WriteLine("Señ@r " + this.titular.nombre + " en total vas a pagar " + cuota * this.meses + " por tu viaje a " + this.destino);
        }
    }
}
