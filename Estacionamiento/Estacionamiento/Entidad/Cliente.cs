using System.ComponentModel.DataAnnotations;

namespace Estacionamiento.Entidad
{
    public class Cliente
    {
        [Key]
        public int DNI { get; set; }
        [MaxLength(50)]
        public string? Nombre { get; set; }
        [MaxLength(100)]
        public string? Apellido { get; set; }
        public int? Telefono { get; set; }
    }
}
