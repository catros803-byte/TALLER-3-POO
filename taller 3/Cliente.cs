using System;
using System.Collections.Generic;
using System.Text;

namespace taller_3
{
    
    
        class Cliente
        {
            public int IdCliente { get; set; }
            public string Nombre { get; set; }
            public string Documento { get; set; }

            public Cliente(int id, string nombre, string documento)
            {
                IdCliente = id;
                Nombre = nombre;
                Documento = documento;
            }

            public void MostrarCliente()
            {
                Console.WriteLine($"Cliente: {Nombre}");
                Console.WriteLine($"Documento: {Documento}");
            }
        }
    }