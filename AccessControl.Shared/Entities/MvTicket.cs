using System.ComponentModel.DataAnnotations;

namespace AccessControl.Shared.Entities
{
    public class MvTicket
    {
        public int Id { get; set; }

        public DateTime? FechaUso { get; set; }

        public bool FueUsada { get; set; }

        public string? Porteria { get; set; }
    }
}
