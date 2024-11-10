using System.ComponentModel.DataAnnotations;

namespace Estacionamiento.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        public DateTime Ingreso { get; set; }
        public DateTime Salida { get; set; }

        public Vehiculo? Vehiculo { get; set; }

        public decimal? Tarifa { get; set; }


    }
}
