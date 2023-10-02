using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace TrabajoIntegradorSofttekFront.Models
{
    public class Login
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int dni { get; set; }
        public long cuil { get; set; }
        public int roleId { get; set; }
        public string token { get; set; }
    }
}
