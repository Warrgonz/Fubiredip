using static System.Runtime.InteropServices.JavaScript.JSType;

namespace fubi_client.Models
{
    public class User
    {
        public string? id_usuario { get; set; }
        public string? cedula { get; set; }
        public string? nombre { get; set; }
        public string? primer_apellido { get; set; }
        public string? segundo_apellido { get; set; }
        public string? telefono { get; set; } 
        public Date? fecha_nacimiento { get; set; } 
        public short? rol { get; set; }
        public bool activo { get; set; } = true;

    }


}
