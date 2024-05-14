using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Cache
{
    public static class UserLoginCache
    {
        public static string Id { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Email { get; set; }
        public static string Sexo { get; set; }
        public static DateTime Fecha_Nacimineto { get; set; }
        public static int Rol { get; set; }
    }
}
