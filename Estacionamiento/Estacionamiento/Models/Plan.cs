using System.ComponentModel.DataAnnotations;

namespace Estacionamiento.Models
{
    public class Plan
    {
        [Key]
        public int Id { get; set; }

        public double Precio { get; set; }  

        public TipoPlan TipoPlan { get; set; }  

        public TipoVehiculo TipoVehiculo { get; set; }   
    }
}
