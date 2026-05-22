
using System;
using taller_3;

namespace taller_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 =
                new Cliente(1, "Carlos Perez", "123456");

            Habitacion habitacion1 =
                new Habitacion(101, "Suite", 300000);

            ServicioComplementario spa =
                new ServicioComplementario("Spa", 50000);

            ServicioComplementario restaurante =
                new ServicioComplementario("Restaurante", 80000);

            Reserva reserva1 =
                new Reserva(1, cliente1, habitacion1);

            reserva1.AgregarServicio(spa);
            reserva1.AgregarServicio(restaurante);

            double total = reserva1.CalcularTotal();

            reserva1.Cobro = new Cobro(1, total);

            reserva1.MostrarReserva();

            reserva1.Cobro.MostrarCobro();

            Console.ReadKey();
        }
    }
}