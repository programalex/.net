using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConectarLINQ.Models
{
    public class UsuarioModel
    {

        DataUsuarioDataContext contexto = new DataUsuarioDataContext();

        public List<consept> ListarUsuario()
        {
            List<consept> Lista = new List<consept>();
            var consulta = contexto.consulta();
            foreach (var consept in consulta)
            {
                consept c = new consept();
                c.TipoDocumento = consept.TipoDocumento;
                c.NumeroIdentificacion = consept.NumeroIdentificacion;
                c.Nombre = consept.Nombre;
                c.Fecha = consept.Fecha;
                Lista.Add(c);
            }
            return Lista;
        }

        public consept BuscarUsuario(int NumeroIdentificacion)
        {
            consept c = new consept();
            try
            {
                var consulta = contexto.crud_consulta(NumeroIdentificacion);
                foreach (var consept in consulta)
                {
                    c.NumeroIdentificacion = consept.NumeroIdentificacion;
                    c.TipoDocumento = consept.TipoDocumento;
                    c.Nombre = consept.Nombre;
                    c.Fecha = consept.Fecha;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return c;
        }

        public string InsertarUsuario(consept c)
        {
            string resultado = String.Empty;
            try
            {
                contexto.insertar(c.NumeroIdentificacion, c.TipoDocumento, c.Nombre, c.Fecha);
                resultado = "ok";
            }

            catch (Exception ex)
            {
                resultado = ex.Message;


            }
            return resultado;
        }

        public string ActualizarUsuario(consept c)
        {
            string resultado = String.Empty;
            try
            {
                contexto.crud_actualizar(c.NumeroIdentificacion, c.TipoDocumento, c.Nombre, c.Fecha);
                resultado = "ok";
            }
            catch (Exception ex)
            {
                resultado = ex.Message;


            }
            return resultado;
        }

        public string EliminarUsuario(int NumeroIdentificacion)
        {
            string resultado = String.Empty;
            try
            {
                contexto.crud_eliminar(NumeroIdentificacion);
                resultado = "ok";
            }
            catch (Exception ex)
            {
                resultado = ex.Message;


            }
            return resultado;
        }

        

    }

}
