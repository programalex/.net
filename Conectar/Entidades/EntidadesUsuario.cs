using Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadesUsuario
    {
    }


    public class Usuario
    {

        public Usuario() {

        }

        public Usuario(consept concept)
        {

            this.TipoDocumento = concept.TipoDocumento;
            this.NumeroIdentificacion = concept.NumeroIdentificacion;
            this.Nombre  = concept.Nombre;
            this.Fecha = concept.Fecha;

        }

        public int? TipoDocumento { get; set; }
        public int NumeroIdentificacion { get; set; }
        public string Nombre { get; set; }
        public DateTime? Fecha { get; set; }


    }
}
