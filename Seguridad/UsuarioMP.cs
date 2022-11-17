using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Xml;
using System.Xml.Linq;


namespace Servicios
{
    public class UsuarioMP
    {
        Crear_BD BD = new Crear_BD();
        

   

        public List<Usuario> Mostrar_usuarios()
        {

            var query =

                from Usuario in XElement.Load("IADA_BD.xml").Elements("Usuario")

                select new Usuario(Convert.ToString(Usuario.Element("Clave").Value))
                {

                    ID_usuario = (Convert.ToInt32(Usuario.Element("ID_usuario").Value)),
                    Nombre = (Convert.ToString(Usuario.Element("Nombre").Value))

                };

            List<Usuario> usuario_consulta = query.ToList<Usuario>();
            return usuario_consulta;
        }



        public void Agregar_usuario(Usuario usu)
        {
            if (System.IO.File.Exists("IADA_BD.xml") == false)

            { this.BD.Crear_nueva_BD("IADA_BD.xml"); }

            XDocument xmlBD = XDocument.Load("IADA_BD.xml");
            xmlBD.Element("BD").Add(new XElement("Usuario", new XElement("ID_usuario", usu.ID_usuario), new XElement("Nombre", usu.Nombre),
                new XElement("Clave", usu.Obtener_pass())));

            xmlBD.Save("IADA_BD.xml");

        }
        public bool Checkear_bd()
        {
            if (System.IO.File.Exists("IADA_BD.xml") == false)
            { return false; }   // no existe el archivo
            else
            { return true; }

        }

        public bool Checkear_usuario(Usuario usu)     ///checkea si existe el ID
        {
            if (System.IO.File.Exists("IADA_BD.xml") == false)

            {
                BD.Crear_nueva_BD("IADA_BD.xml");
                return false;
            }


            var query =

                   from Usuario in XElement.Load("IADA_BD.xml").Elements("Usuario")

                   select new Usuario
                   {
                       ID_usuario = (Convert.ToInt32(Usuario.Element("ID_usuario").Value))
                   };

            List<Usuario> usuario_consulta = query.ToList<Usuario>();
            if (usuario_consulta.Count == 0)
            { return false; }
            foreach (Usuario us in usuario_consulta)
            {
                if (us.ID_usuario == usu.ID_usuario)

                    return true;
            }
            return false;
        }
        public void Modificar_usuario(Usuario usu)
        {
            XmlDocument archivo = new XmlDocument();
            archivo.Load("IADA_BD.xml");
            XmlNodeList lista_usuario = archivo.SelectNodes("Usuario");

            foreach (XmlNode nodo in lista_usuario)

            {
                if (nodo.SelectSingleNode("ID").InnerText == Convert.ToString(usu.ID_usuario))
                {
                    nodo.SelectSingleNode("Nombre").InnerText = usu.Nombre;
                    nodo.SelectSingleNode("Pass").InnerText = usu.Obtener_pass();
                    archivo.Save("IADA_BD.xml");
                    break;
                }
            }
        }


    }
}
