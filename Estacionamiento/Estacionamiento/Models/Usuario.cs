using System.ComponentModel.DataAnnotations;

namespace Estacionamiento.Models
{
    public class Usuario
    {
        [Key]
        public int Dni {  get; set; }

        public string? Nombre { get; set; }

        public string? Apellido { get; set; }

        public string? UserName { get; set; }

        public string? Password { get; set; }   

        public DateTime? FehcaNacimiento { get; set; }

        public DateTime? FechaAlta { get; set; }

        //public DateTime? UltimoAcceso { get; set; }

 
    }
}
