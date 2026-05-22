using System;
using System.Collections.Generic;
using System.Text;

namespace taller_3
{
   
        class Reserva
        {
            public int IdReserva { get; set; }

            public Cliente Cliente { get; set; }

            public Habitacion Habitacion { get; set; }

            public List<ServicioComplementario> Servicios { get; set; }

            public Cobro Cobro { get; set; }

            public Reserva(int id, Cliente cliente, Habitacion habitacion)
            {
                IdReserva = id;
                Cliente = cliente;
                Habitacion = habitacion;
                Servicios = new List<ServicioComplementario>();
            }

            public void AgregarServicio(ServicioComplementario servicio)
            {
                Servicios.Add(servicio);
            }

            public double CalcularTotal()
            {
                double total = Habitacion.PrecioNoche;

                foreach (var servicio in Servicios)
                {
                    total += servicio.Costo;
                }

                return total;
            }

            public void MostrarReserva()
            {
                Console.WriteLine("\n===== RESERVA =====");

                Cliente.MostrarCliente();

                Habitacion.MostrarHabitacion();

                Console.WriteLine("\nServicios:");

                foreach (var servicio in Servicios)
                {
                    Console.WriteLine($"- {servicio.Nombre} : ${servicio.Costo}");
                }

                Console.WriteLine($"\nTOTAL: ${CalcularTotal()}");
            }
        }
    }

