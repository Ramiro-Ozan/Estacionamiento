using System.Net.Sockets;

namespace Estacionamiento.Models
{
    public class Cliente : Usuario
    {
        public List<Ticket> Tickets { get; set; }

        public List<Version>? Vehiculos { get; set; }
    }
}
