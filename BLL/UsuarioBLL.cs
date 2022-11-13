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
      //  public void Primer_ingreso(Usuario usu) { usMP.Primer_ingreso(usu); }
        public void Agregar_usuario(Usuario usu) { usMP.Agregar_usuario(usu); }
        public List<Usuario> Mostrar_usuarios() { return usMP.Mostrar_usuarios(); }
        public bool Checkear_usuario(Usuario usu) { return usMP.Checkear_usuario(usu); }
    }
}
