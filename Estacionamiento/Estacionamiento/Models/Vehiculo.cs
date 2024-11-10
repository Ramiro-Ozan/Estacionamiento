using System.ComponentModel.DataAnnotations;

namespace Estacionamiento.Models
{
    public class Vehiculo
    {
        [Key]
        public string Patente { get; set; } 

        public string Marca { get; set; }

        public string Modelo { get; set; }
        public TipoVehiculo TipoDeVehiculo { get; set; }
    }
}
