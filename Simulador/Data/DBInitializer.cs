using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulador.Models;

namespace Simulador.Data
{
    public class DBInitializer
    {
        public static void Initialize(SimuladorContext context)
        {

            context.Database.EnsureCreated();
            if (context.estimacion_servicios.Any())

            {
                return;
            }
            {
                var estimacion_servicios = new estimacion_servicios[]
                {
                    new estimacion_servicios {id_suscripcion= 4555, unidad_produccion= "288y", total_producciones=88, total_mensual=776.98, producto_servicio_id_producto=876544 }
                };

                foreach (estimacion_servicios a in estimacion_servicios)
                {
                    context.estimacion_servicios.Add(a);
                }
                context.SaveChanges();
            }

        }
    }
}