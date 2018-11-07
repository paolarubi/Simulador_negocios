using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Simulador.Models
{
    public class producto_servicio
    {
        [Key]
        public int id_producto { get; set; }

        [Required(ErrorMessage ="Campo requerido")]
        [StringLength(65, MinimumLength =5, ErrorMessage = "El nombre del producto debe tener de 5 a 65 caracteres")]
        public string producto_nombre { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(45, MinimumLength = 5, ErrorMessage = "La unidad de produccion debe tener de 5 a 45 caracteres")]
        public string unidad_produccion { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public int produccion_mensual { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public Double costo_unitario { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public Double margen_utilidad { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public Double precio_public { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public int datos_empresa_id_empresa { get; set; }

    }
}
