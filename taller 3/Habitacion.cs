using System;
using System.Collections.Generic;
using System.Text;

namespace taller_3
{
    
        class Habitacion
        {
            public int Numero { get; set; }
            public string Tipo { get; set; }
            public double PrecioNoche { get; set; }

            public Habitacion(int numero, string tipo, double precio)
            {
                Numero = numero;
                Tipo = tipo;
                PrecioNoche = precio;
            }

            public void MostrarHabitacion()
            {
                Console.WriteLine($"Habitación: {Numero}");
                Console.WriteLine($"Tipo: {Tipo}");
                Console.WriteLine($"Precio: ${PrecioNoche}");
            }
        }
    }