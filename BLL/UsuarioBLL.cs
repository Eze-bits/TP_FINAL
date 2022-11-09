using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Mapper_DAL;

namespace BLL
{
    public class UsuarioBLL
    {
        UsuarioMP usMP = new UsuarioMP();
        public void Primer_ingreso(Usuario usu) { usMP.Primer_ingreso(usu); }
    }
}
