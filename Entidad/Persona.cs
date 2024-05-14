using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Persona
    {
        public Persona()
        {
            Rol = 0;
        }
        public string id { get; set; }
        public string TipoId { get; set; }  
        public string Nombre { get; set; }
        public string Apellidó { get; set; }
        public string Sexo { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
        public int Rol { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Telefono { get; set; }
        public int Edad { get; set; }
        
    }
}
