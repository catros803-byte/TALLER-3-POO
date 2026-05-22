using System;
using System.Collections.Generic;
using System.Text;

namespace taller_3
{
    
    
        class ServicioComplementario
        {
            public string Nombre { get; set; }
            public double Costo { get; set; }

            public ServicioComplementario(string nombre, double costo)
            {
                Nombre = nombre;
                Costo = costo;
            }
        }
   }

