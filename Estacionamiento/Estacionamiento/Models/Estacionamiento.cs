using System.ComponentModel.DataAnnotations;

namespace Estacionamiento.Models
{
    public class Estacionamiento
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Direcion {  get; set; }
        public ICollection<Vehiculo>? Plaza { get; set; }
        public ICollection<Cliente>? Clientes { get; set; }
        public ICollection<Ticket>? Tickets { get; set; }
        public int MaxPlaza { get; set; }

        public List<TipoVehiculo>? tipoVehiculos { get; set; }
     }
}
