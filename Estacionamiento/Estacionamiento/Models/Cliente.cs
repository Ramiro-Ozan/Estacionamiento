using System.Net.Sockets;

namespace Estacionamiento.Models
{
    public class Cliente : Usuario
    {
        public Ticket? Ticket { get; set; }

        public Version? Vehiculo { get; set; }
        public int EstacionamientoId { get; set; }

        public Estacionamiento? Estacionamiento { get; set; }



    }
}
