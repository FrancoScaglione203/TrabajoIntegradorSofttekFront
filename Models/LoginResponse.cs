namespace TrabajoIntegradorSofttekFront.Models
{
    public class LoginResponse
    {
        public string Nombre { get; set; }
        public long Cuil { get; set; }
        public string Token { get; set; }
        public int dni { get; set; }
        public int roleId { get; set; }
    }
}
