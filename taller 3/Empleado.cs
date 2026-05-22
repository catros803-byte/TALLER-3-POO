using System;
using System.Collections.Generic;
using System.Text;

namespace taller_3
{
   
        class Empleado
        {
            public int IdEmpleado { get; set; }

            public string Nombre { get; set; }

            public string Cargo { get; set; }

            public Empleado(int id, string nombre, string cargo)
            {
                IdEmpleado = id;
                Nombre = nombre;
                Cargo = cargo;
            }

            public void MostrarEmpleado()
            {
                Console.WriteLine($"Empleado: {Nombre}");
                Console.WriteLine($"Cargo: {Cargo}");
            }
        }
   }

