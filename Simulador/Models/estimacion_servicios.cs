using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Simulador.Models
{
    public class estimacion_servicios
    {

        [Key]
        public int id_suscripcion { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(45, MinimumLength = 5, ErrorMessage = "La unidad de produccion debe tener de 5 a 45 caracteres")]
        public string unidad_produccion { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public int total_producciones { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public Double total_mensual { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public int producto_servicio_id_producto { get; set; }

    }
}
