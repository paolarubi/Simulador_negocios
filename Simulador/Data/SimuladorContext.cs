using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Simulador.Models
{
    public class SimuladorContext : DbContext
    {
        public SimuladorContext(DbContextOptions<SimuladorContext> options)
            : base(options)
        {

        }
        public DbSet<Simulador.Models.estimacion_servicios> estimacion_Servicios { get; set; }
        public DbSet<Simulador.Models.producto_servicio> producto_Servicios { get; set; }
    }
}