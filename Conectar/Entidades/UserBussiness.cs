using Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UserBussiness
    {


        public List<Usuario> GetAll()
        {
            using (var db = new ModelConnection())
            {
                var Listausuarios = db.consept.ToList();
                return Listausuarios.Select(x => new Usuario(x)).ToList();
            }

            
        }


        

    }
}
