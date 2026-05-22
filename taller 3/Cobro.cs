using System;
using System.Collections.Generic;
using System.Text;

namespace taller_3
{
   

   
    
        class Cobro
        {
            public int IdCobro { get; set; }
            public double Total { get; set; }

            public Cobro(int idCobro, double total)
            {
                IdCobro = idCobro;
                Total = total;
            }

            public void MostrarCobro()
            {
                Console.WriteLine("\n===== COBRO =====");
                Console.WriteLine($"Id Cobro: {IdCobro}");
                Console.WriteLine($"Total: ${Total}");
            }
        }
   }

