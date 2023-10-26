namespace template_method
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("carlos", 32, 7, 4000000, 1, true);
            Cliente cliente2 = new Cliente("juan", 32, 6, 1200000, 0, true);
            PrestamoHipotecario prestamoHipotecario = new PrestamoHipotecario(cliente1, 500000, 7);
            PrestamoPersonal prestamoPersonal = new PrestamoPersonal(cliente2, 700000, 8);
            PrestamoViaje prestamoViaje = new PrestamoViaje(cliente1, 3000000, 13, "Medellin");
            PrestamoHipotecario prestamoHipotecario1 = new PrestamoHipotecario(cliente2, 1000000, 5);
        }
    }

}
